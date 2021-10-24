using System;
using SomafixCatalog.Data;

namespace SomafixCatalog.Models
{
    public class ProductViewModel
    {
        public int ID { get; }
        public string Name { get; set; }
        public string PicUrl { get; set; }
        public string Description { get; set; }

        public ProductViewModel(){}
        public ProductViewModel(string name, string picUrl, string description)
        {
            Name = name;
            PicUrl = picUrl;
            Description = description;
        }
        public ProductViewModel(int id, string name, string picUrl, string description)
        {
            ID = id;
            Name = name;
            PicUrl = picUrl;
            Description = description;
        }


        public static ProductViewModel ConvertToModel(Product product) =>
            new ProductViewModel(product.ID, product.Name, product.PicUrl, product.Description);
       


        

    }
}
