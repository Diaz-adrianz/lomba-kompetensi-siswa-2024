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
using System.Windows.Forms.DataVisualization.Charting;

namespace apotek_xyz_wf.Forms
{
    public partial class KelolaLaporanForm : Form
    {
        private readonly TransaksiRepo transaksiRepo = new TransaksiRepo();
        private List<TransaksiReportDTO> transaksi;

        public KelolaLaporanForm()
        {
            InitializeComponent();
        }

        private void GetTransaksi()
        {
            transaksi = transaksiRepo.GetTransaksiReport();

            TableTransaksi.Rows.Clear();
            foreach (var tr in transaksi)
            {
                TableTransaksi.Rows.Add(
                    tr.Tgl_Transaksi,
                    tr.Total_Bayar
                );
            }
            TableTransaksi.ClearSelection();
            Components.AdjustTableHeight(TableTransaksi);
        }

        private void KelolaLaporanFormLoad(object sender, EventArgs e)
        {
            TableTransaksi.ClearSelection();
            GetTransaksi();
        }

        private void ButtonGenerateChartClick(object sender, EventArgs e)
        {
            ChartTransaksi.Series["Omset"].XValueType = ChartValueType.Date;
            ChartTransaksi.Series["Omset"].Points.Clear();
            
            foreach (var tr in transaksi.OrderBy(tr => tr.Tgl_Transaksi))
            {
                string tanggalStr = tr.Tgl_Transaksi.ToString("dd/MM/yyyy");
                int omset = Convert.ToInt32(tr.Total_Bayar);

                ChartTransaksi.Series["Omset"].Points.AddXY(tanggalStr, omset);
            }
        }

        private void ButtonLoadClick(object sender, EventArgs e)
        {

        }
    }
}
