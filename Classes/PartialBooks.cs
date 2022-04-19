using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulExam
{
    public partial class Books
    {
        public string Title
        {
            get
            {
                return "Название: " + bookName + " | Жанр: " + genre;
            }
        }
    }
}
