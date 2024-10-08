﻿using DataAccessLayer.Entities.Base;

namespace DataAccessLayer.Entities
{
    public class ProductFeature : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public long? ProductId { get; set; }
        public Product Product { get; set; }


    }
}
