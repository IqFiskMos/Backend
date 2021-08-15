using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts_and_Views.Models
{
    public class Article
    {
        public DateTime ArticleDate { get; set; }

        public Article()
        {
            ArticleDate = DateTime.Now;
        }
    }
}
