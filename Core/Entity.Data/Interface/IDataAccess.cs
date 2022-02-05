using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Interface
{
    public interface IDataAccess
    {
        #region Prpduct     
        IProductRepository ProductAccess { get; set; }
        ICategoryRepository CategoryAccess { get; set; }
        IPriceRepository PriceAccess { get; set; }
        ISubCategoryRepository SubCategoryAccess { get; set; }
        #endregion

        #region Order
        IOrderRepository OrderAccess { get; set; }
        IRejectOrderRepository RejectOrderAccess { get; set; }
        IReceiveOrderRepository ReceiveOrderAccess { get; set; }
        #endregion

        void SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
