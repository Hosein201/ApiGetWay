using Entity.Data.Interface;
using MediatR;
using OrderProcessing.Mapper.Commands.Product;
using OrderProcessing.Mapper.Dto.Product;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing.Product.Commands.Handler
{
    public class ProductInsertCommandHandler : IRequestHandler<ProductInsertCommand, ResponseProductDto>
    {
        private readonly IDataAccess dataAccess;

        public ProductInsertCommandHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<ResponseProductDto> Handle(ProductInsertCommand request, CancellationToken cancellationToken)
        {
            return await dataAccess.ProductAccess.AddProduct(new Entity.Models.Product
            {

            }, cancellationToken);
        }
    }
}
