using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeCrab.Models
{
    public class CategoryAndMovieRelation
    {
        [Key] [Required] public int Id { get; set; }

        public int MovieId { get; set; }

        public int CategoryId { get; set; }


        public virtual Movie Movie { get; set; }

        public virtual Category Category { get; set; }
    }
}