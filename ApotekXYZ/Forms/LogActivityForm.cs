using apotek_xyz_wf.Database;
using apotek_xyz_wf.Repository;
using apotek_xyz_wf.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek_xyz_wf.Forms
{

    public partial class LogActivityForm : Form
    {
        private readonly LogRepo logRepo = new LogRepo();
        
        public LogActivityForm()
        {
            InitializeComponent();
        }
        
        private void GetLogs()
        {
            List<Tbl_Log> logs = logRepo.GetLogs(InputTanggal.Value);

            TableLogs.Rows.Clear();
            foreach (var log in logs)
            {
                TableLogs.Rows.Add(
                    log.Id_Log,
                    log.Tbl_User.Username,
                    log.Waktu,
                    log.Aktivitas
                );
            }
            TableLogs.ClearSelection();
            Components.AdjustTableHeight(TableLogs);
        }

        private void LogActivityFormLoad(object sender, EventArgs e)
        {
            TableLogs.ClearSelection();
            GetLogs();
        }

        private void ButtonLoadClick(object sender, EventArgs e)
        {
            GetLogs();
        }
    }

}
