using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tokenkong.dal;
using System.Data;

namespace tokenkong.models
{
    class SaleModel
    {
        public long ID { get; set; }
        public string DESCRIPTION { get; set; }
        public int USER_ID { get; set; }
        public DateTime DATE { get; set; }
        //DateTime dt = reader.GetDateTime(3);
        public int CLIENT_ID { get; set; }
        public float AMOUNT { get; set; }
        public List<int> PRODUCTS { get; set; }

    }
}
