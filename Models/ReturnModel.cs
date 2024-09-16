using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class ReturnModel
    {
        public int id_return { get; set; }
        public int id_book { get; set; }
        public int id_user { get; set; }

        public DateTime return_date { get; set; }

    }
}
