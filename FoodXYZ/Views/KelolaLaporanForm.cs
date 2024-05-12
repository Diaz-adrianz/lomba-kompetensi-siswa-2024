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
using System.Windows.Forms.DataVisualization.Charting;

namespace FoodXYZ.Views
{
    public partial class KelolaLaporanForm : Form
    {
        private readonly FoodXYZDB db = new FoodXYZDB();

        List<Transaksi> transaksis = new List<Transaksi> { };

        public KelolaLaporanForm()
        {
            InitializeComponent();
        }

        private void GetTransaksi()
        {
            transaksis = db.Transaksis
                .Where(t =>
                    t.TglTransaksi >= InpTanggalAwal.Value.Date &&
                    t.TglTransaksi <= InpTanggalAkhir.Value.Date
                ).ToList();

            TabTransaksi.Rows.Clear();
            foreach (var item in transaksis)
            {
                TabTransaksi.Rows.Add(
                   item.NoTransaksi,
                   item.TglTransaksi,
                   item.TotalBayar,
                   item.User.Nama
                );
            }
        }

        private void ButFilterClick(object sender, EventArgs e)
        {
            GetTransaksi();
        }

        private void ButGetChartClick(object sender, EventArgs e)
        {
            ChaOmset.Series["Omset"].XValueType = ChartValueType.Date;
            ChaOmset.ChartAreas[0].AxisX.Minimum = InpTanggalAwal.Value.Date.ToOADate();
            ChaOmset.ChartAreas[0].AxisX.Maximum = InpTanggalAkhir.Value.Date.ToOADate();

            foreach (var tr in transaksis)
            {
                ChaOmset.Series["Omset"].Points.AddXY(
                    tr.TglTransaksi?.Date.ToOADate(),
                    tr.TotalBayar
                );
            }
        }

        private void KelolaLaporanFormLoad(object sender, EventArgs e)
        {
            InpTanggalAkhir.Value = DateTime.Now.Date.AddDays(7);

            GetTransaksi();
        }
    }
}
