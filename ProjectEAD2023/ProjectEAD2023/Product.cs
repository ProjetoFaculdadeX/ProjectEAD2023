using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEAD2023
{
    public class Product
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public string? Lote { get; set; }
        public DateTime Validade { get; set; }
        public int Quantity { get; set; }

    }
  
}
