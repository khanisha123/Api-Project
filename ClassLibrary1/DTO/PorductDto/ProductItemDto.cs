using System;
using System.Collections.Generic;
using System.Text;

namespace Api_Project.BLL.DTO.PorductDto
{
    public class ProductItemDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isDelete { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
