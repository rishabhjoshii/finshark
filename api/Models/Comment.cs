using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace api.Models{

    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        //[ForeignKey(name:"Stock")]
        public int? StockId { get; set; } 
    
        //Navigation
        public Stock? Stock { get; set; }
    }

}
