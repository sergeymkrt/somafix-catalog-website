using System;
namespace SomafixCatalog.Data
{
    public class Message
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }
        public string _message { get; set; }

    }
    public class Product
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string PicUrl { get; set; }
        public string Description { get; set; }

        
        public Product(string name, string picUrl, string description)
        {
            Name = name;
            PicUrl = picUrl;
            Description = description;
        }

    }
}
