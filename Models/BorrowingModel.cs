using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class BorrowingModel
    {
        public int id_borrowing { get; set; }
        public int id_book { get; set; }
        public int id_user { get; set; }

        public DateTime borrowing_date { get; set; }

        public DateTime expiration_date { get; set; }

    }
}
