using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeCrab.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryAndMovieRelation> CategoryAndMovieRelations { get; set; }
    }
}