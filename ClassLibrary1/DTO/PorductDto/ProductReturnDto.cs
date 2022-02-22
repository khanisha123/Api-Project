using System;
using System.Collections.Generic;
using System.Text;

namespace Api_Project.BLL.DTO.PorductDto
{
    public class ProductReturnDto
    {
        public int TotalCount { get; set; }
        public List<ProductItemDto> Items { get; set; }
    }
}
