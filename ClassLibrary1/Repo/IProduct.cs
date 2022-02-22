using Api_Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api_Project.BLL.DTO;
using Api_Project.BLL.DTO.PorductDto;

namespace Api_Project.BLL.Repo
{
    public interface IProduct
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProduct(int id);
        Task<Product> PostProduct(ProductDto productDto);
        Task<Product> DeleteProduct(int id);
    }
}
