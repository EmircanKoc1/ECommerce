﻿using DataAccessLayer.Entities.Base.Concretes;

namespace DataAccessLayer.Entities
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
