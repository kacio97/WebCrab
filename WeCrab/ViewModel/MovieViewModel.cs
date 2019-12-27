using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeCrab.Models;

namespace WeCrab.ViewModel
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Category> Categories { get; set; }
    }
}