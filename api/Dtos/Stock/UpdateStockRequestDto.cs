using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol can't be more than 10 characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(15, ErrorMessage = "CompanyName can't be more than 15 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(0,1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.000,100)]
        public decimal LastDiv { get; set; } //Last divident

        [Required]
        [MaxLength(15, ErrorMessage = "Industry name can't be more than 15 characters")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(0,100000000)]
        public long MarketCap { get; set; }
    }
}