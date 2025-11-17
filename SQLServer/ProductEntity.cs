using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDBConnectionSample.SQLServer
{
    public sealed class ProductEntity
    {
        public ProductEntity(
            int productId,
            string productName,
            int price
            )
        {
            Id = productId;
            Name = productName;
            Price = price;
        }

        public int Id { get;  }
        public string Name { get; }
        public int Price { get;  }
    }
}
