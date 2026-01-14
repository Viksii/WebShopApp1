using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Contracts
{
  
        public interface IProductService
        {
            bool Create(string name, int brandId, int categoryId, string picture, int quantity, decimal price, decimal discount);
            bool Update(int productid, string name, int brandId, int categoryid, string picture, int quantity, decimal price, decimal discount);
            List<Product> GetProducts();
            Product GetProductById(int productId);
            bool RemoveById(int dogproductId);
            List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandName);

        }

    }

