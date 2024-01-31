﻿using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
