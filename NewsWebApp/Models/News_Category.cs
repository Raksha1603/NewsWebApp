using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace NewsWebApp.Models
{
    public class News_Category
    {

        
        [Key]
        
        public string CatID { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
    }
}
