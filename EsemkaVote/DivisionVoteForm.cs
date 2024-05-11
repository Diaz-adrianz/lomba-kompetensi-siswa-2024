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
    public partial class DivisionVoteForm : Form
    {
        private readonly EsemkaVoteDB db = new EsemkaVoteDB();

        public int? divisionId;
        public int? votingHeaderId;

        public DivisionVoteForm()
        {
            InitializeComponent();
        }

        private void getData()
        {
            if (divisionId == null || votingHeaderId == null) return;

            Division div = db.Divisions.FirstOrDefault(d => d.Id == divisionId);
            if (div == null) return;

            LabHeadTitle.Text = $"{div.Name} Detail";

            decimal totalVotes = db.VotingDetails
                .Where(vd =>
                    vd.VotingCandidate.VotingHeaderId == votingHeaderId &&
                    vd.Employee.DivisionId == div.Id
                ).Count();

            LabHeadVotes.Text = $"Total Vote: {totalVotes}";

            List<Candidate> candidates = db.VotingCandidates
                .Where(vc =>
                    vc.VotingHeaderId == votingHeaderId
                ).Select(vc => new Candidate
                {
                    CandidateName = vc.Employee.Name,
                    TotalVotes = vc.VotingDetails.Where(vd => vd.Employee.DivisionId == div.Id).Count(),
                    Percentage = (decimal)vc.VotingDetails.Where(vd => vd.Employee.DivisionId == div.Id).Count() / totalVotes * 100
                })
                .OrderBy(vc => vc.TotalVotes)
                .ToList();

            PanCandidates.Controls.Clear();
            foreach (var item in candidates)
            {
                CandidateBox candidateBox = new CandidateBox();
                candidateBox.LabCandidateName.Text = item.CandidateName;
                candidateBox.LabVoteCount.Text = $"Vote Count: {item.TotalVotes}";
                candidateBox.LabVotePercent.Text = $"{Decimal.Round(item.Percentage,2)}%";

                candidateBox.TopLevel = false;
                candidateBox.Dock = DockStyle.Left;
                PanCandidates.Controls.Add(candidateBox);
                candidateBox.Show();

                Panel panel = new Panel();
                panel.Width = 8;
                panel.Dock = DockStyle.Left;
                PanCandidates.Controls.Add(panel);
            }

            if (PanCandidates.Controls.Count == candidates.Count * 2)
            {
                PanCandidates.Controls[candidates.Count * 2 - 2].BackColor = Color.Yellow;
            }
        }

        private class Candidate
        {
            public string CandidateName { get; set; }
            public int TotalVotes { get; set; }
            public decimal Percentage { get; set; }

        }

        protected override void OnShown(EventArgs e)
        {
            getData();
            base.OnShown(e);
        }
    }
}
