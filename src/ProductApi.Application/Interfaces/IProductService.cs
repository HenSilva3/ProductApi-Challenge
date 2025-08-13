using ProductApi.Application.DTOs;
using ProductApi.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(CreateProductDto productDto);
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
