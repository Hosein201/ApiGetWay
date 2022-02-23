using MediatR;
using OrderProcessing.Mapper.Dto.Product;
using System;

namespace OrderProcessing.Mapper.Queries.Product
{
    public class GetProdcutByIdQuery : IRequest<ResponseProductDto>
    {
        public Guid ProductId { get; set; }
    }
}
