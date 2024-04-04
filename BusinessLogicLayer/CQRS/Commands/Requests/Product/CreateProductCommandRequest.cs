using BusinessLogicLayer.CQRS.Commands.Responses.Product;
using CoreLayer.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Product
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }
        public long? CategoryId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? BrandId { get; set; }

    }
}
