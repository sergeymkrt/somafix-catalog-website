using System;
using System.Collections.Generic;

namespace SomafixCatalog.Data
{
    public interface IMessageRepository : IDisposable
    {
        IEnumerable<Message> GetMessages();
        Message GetMessageByID(int messageID);
        void InsertMessage(Message message);
        void DeleteMessage(int messageID);
        void Save();
    }
    public interface IProductRepository: IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productID);
        void InsertProduct(Product product);
        void DeleteProduct(int productID);
        void UpdateProduct(Product product);
        void Save();
    }
}
