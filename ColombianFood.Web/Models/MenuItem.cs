using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ColombianFood.Web.Models
{
    public class MenuItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The maximun length for filed {0} is {1} characters")]
        public string Name { get; set; }

        
        [MaxLength(500, ErrorMessage = "The maximun length for filed {0} is {1} characters")]
        public string Description { get; set; }

        public string Image { get; set; }

        public string Spicyness { get; set; }
        public enum EScipy { NA=0,Spicy=1,VerySpicy=2}

        [Range(1,int.MaxValue,ErrorMessage = "Price should be greater then ${1}")]
        public double Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "SubCategory")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }
    }
}
