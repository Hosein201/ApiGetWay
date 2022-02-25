using MediatR;
using OrderProcessing.Mapper.Dto.Product;
using System.Collections.Generic;

namespace OrderProcessing.Mapper.Queries.Product
{
    public class GetProductsQuery : IRequest<List<ResponseProductDto>>
    {
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
