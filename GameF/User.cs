using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameF
{
    //var olan veya yeni oyuncuların ortak özelliklerini tuttuğumuz class
     public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Mailaddress { get; set; }
    }
}
