using EsemkaVote.components;
using EsemkaVote.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaVote
{
    public partial class ReportForm : Form
    {
        private readonly EsemkaVoteDB db = new EsemkaVoteDB();

        private VotingCandidate candidate;
        private List<DivisionVotes> divisionVotes;
        private decimal totalVotes = 0;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void GetCandidate()
        {
            ClearData();

            VotingHeader evt = db.VotingHeaders.FirstOrDefault(vh => vh.Id.ToString() == SelVoteEvent.SelectedValue.ToString());
            if (evt == null) return;

            LabHeadName.Text = evt.Name;
            LabHeadDesc.Text = evt.Description;

            candidate = db.VotingCandidates
                .Where(vc => vc.VotingHeaderId == evt.Id)
                .Select(vc => new
                {
                    Candidate = vc,
                    Votes = vc.VotingDetails.Count()
                })
                .OrderByDescending(x => x.Votes)
                .Select(x => x.Candidate)
                .FirstOrDefault();
            if (candidate == null) return;

            LabCandidateName.Text = candidate.Employee.Name;
            if (candidate.Employee.Photo != null)
            {
                Image img = (Image)Properties.Resources.ResourceManager.GetObject(candidate.Employee.Photo.Split('.')[0]);
                if (img != null) PicCand.Image = img;
            }

            decimal votes = db.VotingCandidates
                .Where(vc => vc.VotingHeaderId == evt.Id && vc.EmployeeId == candidate.EmployeeId)
                .Select(cd => new
                {
                    Votes = cd.VotingDetails.Count()
                })
                .Select(cd => cd.Votes)
                .FirstOrDefault();
            totalVotes = db.VotingDetails
                .Where(vd => vd.VotingCandidate.VotingHeaderId == evt.Id)
                .Count();

            LabVoteResult.Text = $"{decimal.Round((votes / totalVotes) * 100, 2)}%({votes}/{totalVotes})";

            GetDivisions();
            GetReasons();
        }

        private void ClearData()
        {
            LabHeadName.Text = "Vote XXXX";
            LabHeadDesc.Text = "Vote description";
            LabCandidateName.Text = "Employee name...";
            LabVoteResult.Text = "0%(0/0)";
            PicCand.Image = null;
            TabDivisions.Rows.Clear();
        }

        private void SelVoteEventValueChange(object sender, EventArgs e)
        {
            GetCandidate();
        }

        private void TabDivisionsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TabDivisions.Columns["action"].Index && e.RowIndex >= 0 && divisionVotes.Count > 0)
            {
                DivisionVoteForm divisionVoteForm = new DivisionVoteForm();
                divisionVoteForm.votingHeaderId = int.Parse(SelVoteEvent.SelectedValue.ToString());
                divisionVoteForm.divisionId = divisionVotes[e.RowIndex].DivisionId;
                divisionVoteForm.Show();
            }
        }

        private void ReportFormLoad(object sender, EventArgs e)
        {
            SelVoteEvent.DataSource = db.VotingHeaders.ToList();
            TabDivisions.ClearSelection();
            PanReasons.Controls.Clear();

            GetCandidate();
        }

        private void GetReasons()
        {
            if (candidate == null) return;

            List<VotingDetail> votingDetails = db.VotingDetails
                .Where(vd =>
                    vd.VotingCandidate.VotingHeaderId.ToString() == SelVoteEvent.SelectedValue.ToString() &&
                    vd.VotingCandidate.EmployeeId == candidate.EmployeeId
                ).ToList();

            PanReasons.Controls.Clear();
            foreach (var voting in votingDetails)
            {
                if (voting.Reason == null) continue;

                ReasonBox reasonBox = new ReasonBox();
                reasonBox.TexContent.Text = voting.Reason;

                reasonBox.TopLevel = false;
                reasonBox.Dock = DockStyle.Left;
                PanReasons.Controls.Add(reasonBox);
                reasonBox.Show();
            }
        }

        private void GetDivisions()
        {
            divisionVotes = db.VotingDetails
                .Where(vd =>
                    vd.VotingCandidate.VotingHeaderId.ToString() == SelVoteEvent.SelectedValue.ToString()
                )
                .GroupBy(vd => vd.Employee.Division)
                .Select(vd => new DivisionVotes
                {
                    DivisionId = vd.Key.Id,
                    DivisionName = vd.Key.Name,
                    VoteCount = vd.Count(),
                    Percentage = (decimal)vd.Count() / totalVotes * 100
                })
                .ToList();

            foreach (var item in divisionVotes)
            {
                TabDivisions.Rows.Add(
                    item.DivisionName,
                    item.VoteCount,
                    Decimal.Round(item.Percentage, 2) + "%",
                    "Detail"
                );   
            }
        }

        private class DivisionVotes
        {
            public int DivisionId { get; set; }
            public string DivisionName { get; set; }
            public int VoteCount { get; set; }
            public decimal Percentage { get; set; }
        }
    }
}
