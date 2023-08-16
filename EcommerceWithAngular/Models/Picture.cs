using System.ComponentModel.DataAnnotations;

namespace EcommerceWithAngular.Models
{
    public class Picture
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string PictureFileName { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        //public virtual ICollection<Product> Products { get; set; }=
        //    new HashSet<Product>();


    }
}