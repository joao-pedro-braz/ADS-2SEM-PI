using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tokenkong.dal;
using System.Data;
using MySql.Data.MySqlClient;

namespace tokenkong.models
{
    class ProductModel
    {
        public int ID { get; set; }
        public int QUANTITY { get; set; }
        public string DESCRIPTION { get; set; }
        public string NAME { get; set; }
        public string PROVIDER { get; set; }
        public float PRICE { get; set; }
        public float COST { get; set; }
        public string IMAGE { get; set; }
    }

}
