﻿using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfigurations
{
    public class BrandDetailConfiguration : IEntityTypeConfiguration<BrandDetail>
    {
        public void Configure(EntityTypeBuilder<BrandDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}
