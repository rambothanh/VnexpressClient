using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnexpressClient.Models
{
    public class ImageLink{
       
        public long Id { get; set; }
        public string TextLink {get;set;}
        [ForeignKey("News")]
        public long NewsRefId  {get;set;}
        public News News  {get;set;}

        public long Location { get; set; }
        public string Captain { get; set; }
        
        
    }
}