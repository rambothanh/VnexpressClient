using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace VnexpressClient.Models
{
    public class Category{
       
        public long Id { get; set; }
        
        public string Text {get;set;}
        ICollection<News> News {get;set;}
        
    }
}