using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcWebApi.Models;

namespace MvcWebApi.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id = 1 ,Name="Huitai", Category="People",Price=1.25M},
            new Product{Id = 2,Name="Hello",Category="Hello",Price=4.5M},
            new Product{Id = 3,Name="ViewSonic",Category="Computer",Price=1500M}
        };

        /// <summary>
        /// 返回所有商品
        /// </summary>
        /// <returns>返回一个枚举类型为Product</returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return this.products;
        }

        /// <summary>
        /// 返回单一商品信息
        /// </summary>
        /// <param name="id">商品的ID</param>
        /// <returns>商品</returns>
        public Product GetProductById(int id)
        {
            var product = this.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(resp);
            }
            return product;
        }
        /// <summary>
        /// 返回指定类别所有的商品
        /// </summary>
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return this.products.Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }
    }
}
