using System;
using System.Collections.Generic;
using System.Text;

namespace Api_Project.DAL.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isDelete { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
