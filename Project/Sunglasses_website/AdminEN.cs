using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace Sunglasses_website
{
    public class AdminEN
    {
        public AdminEN()
        {
        }

        public DataSet searchAdmin(String admin)
        {
            AdminCAD c = new AdminCAD();
            DataSet datSet = c.searchAdmin(admin);

            return datSet;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
