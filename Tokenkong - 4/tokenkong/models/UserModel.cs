using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokenkong.models
{
    sealed class UserModel
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public int ROLE { get; set; }

    }
}
