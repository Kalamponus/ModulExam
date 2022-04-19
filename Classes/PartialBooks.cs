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
        public string shopCount
        {
            get
            {
                string count ="";
                int shop = Convert.ToInt32(shopCount.ToString());
                if(shop > 5)
                {
                    count = "Много";
                }
                else if (shop == 0)
                {
                    count = "Нет";
                }
                else
                {
                    count = shopCount.ToString();
                }
                return count;
            }
        }
        public string stockCount
        {
            get
            {
                string count ="";
                int shop = Convert.ToInt32(stockCount.ToString());
                if (shop > 5)
                {
                    count = "Много";
                }
                else if (shop == 0)
                {
                    count = "Нет";
                }
                else
                {
                    count = stockCount.ToString();
                }
                return count;
            }
        }
    }

    
}
