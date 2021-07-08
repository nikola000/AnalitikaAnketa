using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalitikaAnketa.Forms.Classes
{
    class Configurationsingleton
    {
        public string ConnectionString { get; set; }
        public static Configurationsingleton single_instance = null;
        public static Configurationsingleton getInstance()
        {
            if (single_instance == null)
            { single_instance = new Configurationsingleton(); }
            return single_instance;
        }
    }
}
