using apotek_xyz_wf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apotek_xyz_wf.Repository
{
    public class TransaksiReportDTO
    {
        public DateTime Tgl_Transaksi { get; set; }
        public long Total_Bayar { get; set; }
    }

    interface ITransaksiRepo
    {
        List<TransaksiReportDTO> GetTransaksiReport();
    }


    public class TransaksiRepo : BaseRepo, ITransaksiRepo
    {
        public List<TransaksiReportDTO> GetTransaksiReport()
        {
            return db.Tbl_Transaksi
                .GroupBy(tr => tr.Tgl_Transaksi)
                .Select(t =>
                    new TransaksiReportDTO
                    {
                        Tgl_Transaksi = (DateTime) t.Key,
                        Total_Bayar = (long) t.Sum(tr => tr.Total_Bayar)
                    }
                )
                .OrderByDescending(tr => tr.Tgl_Transaksi)
                .ToList();
        }
    }
}
