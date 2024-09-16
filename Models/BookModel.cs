using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class BookModel
    {
        public int id_book { get; set; }

        public string title { get; set; }
        public string author { get; set; }
        public string gender { get; set; }

        public int id_state { get; set; }
    }
}
