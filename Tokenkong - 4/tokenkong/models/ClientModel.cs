using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tokenkong.dal;
using System.Data;

namespace tokenkong.models
{
    class ClientModel
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string CPF { get; set; }

    }
}
