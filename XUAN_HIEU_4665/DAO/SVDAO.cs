using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class SVDAO
    {

        public string ma { get; set; }
        public string ten { get; set; }
        public override string ToString()
        {
            return this.ma + " - " + this.ten;
        }


    }
}
