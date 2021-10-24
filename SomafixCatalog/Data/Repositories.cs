using System;
using System.Collections.Generic;
using System.Linq;

namespace SomafixCatalog.Data
{
    public class MessageRepository:IMessageRepository,IDisposable
    {
        private ApplicationDbContext context;

        public MessageRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void DeleteMessage(int messageID)
        {
            Message message = context.Messages.Find(messageID);
            context.Messages.Remove(message);
        }

        public Message GetMessageByID(int messageID)
        {
            return context.Messages.Find(messageID);
        }

        public IEnumerable<Message> GetMessages()
        {
            return context.Messages.ToList();
        }

        public void InsertMessage(Message message)
        {
            context.Messages.Add(message);
        }

        public void Save()
        {
            context.SaveChanges();
        }


        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
    public class ProductRepository : IProductRepository, IDisposable
    {
        private ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void DeleteProduct(int productID)
        {
            Product product = context.Products.Find(productID);
            context.Products.Remove(product);
        }

        public Product GetProductById(int productID)
        {
            return context.Products.Find(productID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            context.Products.Add(product);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }


        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
