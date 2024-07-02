using apotek_xyz_wf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apotek_xyz_wf.Repository
{
    abstract public class BaseRepo
    {
        protected readonly ApotekDatabase db = new ApotekDatabase();
    }
}
