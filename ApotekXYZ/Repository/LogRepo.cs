using apotek_xyz_wf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apotek_xyz_wf.Repository
{
    interface ILogRepo
    {
        List<Tbl_Log> GetLogs(DateTime date);
    }

    public class LogRepo : BaseRepo, ILogRepo
    {
        public List<Tbl_Log> GetLogs(DateTime date)
        {
            return date != DateTime.MinValue ?
                db.Tbl_Log.Where(l => 
                    l.Waktu.Value.Day == date.Day 
                    && l.Waktu.Value.Month == date.Month 
                    && l.Waktu.Value.Year == date.Year
                ).ToList() :
                db.Tbl_Log.ToList();
        }
    }
}
