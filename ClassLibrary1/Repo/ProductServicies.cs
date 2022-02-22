using Api_Project.BLL.DTO.PorductDto;
using Api_Project.DAL.Data;
using Api_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api_Project.BLL.Repo
{
   public class ProductServicies :IProduct
   {
        private readonly DataContext _context;
        public ProductServicies(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return product;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<ProductDto> GetProduct(int id)
        {
            var product = await _context.Products
                    .FirstOrDefaultAsync(b => b.Id == id);

            ProductDto productDtos = new ProductDto()
            {
                Name = product.Name,
                Price = product.Price
            };

            if (product == null)
            {
                return productDtos;
            }

            return productDtos;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<ProductDto> productDtos = new List<ProductDto>();
            var products = await _context.Products.ToListAsync();

            foreach (var item in products)
            {
                ProductDto productDto = new ProductDto
                {
                    Name = item.Name,
                    Price = item.Price
                };
                productDtos.Add(productDto);
            }

            return productDtos;
        }

        public async Task<Product> PostProduct(ProductDto productDto)
        {
            Product product = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }


       
    }
}
