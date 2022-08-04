using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XventoryLDB
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceIn { get; set; }
        public string PriceOut { get; set; }

        public DateTime fecha = DateTime.Now;


    }
}
