using FoodXYZ.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Views
{
    public partial class LogForm : Form
    {
        private readonly FoodXYZDB db = new FoodXYZDB();

        public LogForm()
        {
            InitializeComponent();
        }

        private void GetLogs()
        {
            var logs = db.Logs.Where(l => 
                l.Waktu.Value.Year == InpTanggal.Value.Year &&
                l.Waktu.Value.Month == InpTanggal.Value.Month &&
                l.Waktu.Value.Day == InpTanggal.Value.Day
            ).ToList();

            TabLogs.Rows.Clear();
            foreach (var item in logs)
            {
                TabLogs.Rows.Add(
                    item.IdLog,
                    item.User.Username,
                    item.Waktu?.ToString("dd MMMM yyyy HH:mm"),
                    item.aktivitas
                );
            }
            TabLogs.ClearSelection();
        }

        private void ButFilterClick(object sender, EventArgs e)
        {
            GetLogs();
        }

        private void LogFormLoad(object sender, EventArgs e)
        {
            TabLogs.ClearSelection();
            GetLogs();
        }
    }
}
