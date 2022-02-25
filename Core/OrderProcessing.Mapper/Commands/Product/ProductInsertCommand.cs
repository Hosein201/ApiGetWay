using MediatR;
using OrderProcessing.Mapper.Dto.Product;

namespace OrderProcessing.Mapper.Commands.Product
{
    public class ProductInsertCommand : IRequest<ResponseProductDto>
    {
    }
}
