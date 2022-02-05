using Entity.Data.Interface;
using Entity.Data.Repository.Order;
using Entity.Data.Repository.Product;
using System.Threading;
using System.Threading.Tasks;

namespace Entity.Data.Repository
{
    public class DataAccess : IDataAccess
    {
        private readonly AppDbContext _dbContext;

        #region Prpduct
        public IProductRepository ProductAccess { get; set; }
        public ICategoryRepository CategoryAccess { get; set; }
        public IPriceRepository PriceAccess { get; set; }
        public ISubCategoryRepository SubCategoryAccess { get; set; }
        #endregion

        #region Order
        public IOrderRepository OrderAccess { get; set; }
        public IRejectOrderRepository RejectOrderAccess { get; set; }
        public IReceiveOrderRepository ReceiveOrderAccess { get; set; }
        #endregion


        public DataAccess(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
            this.ProductAccess = new ProductRepository(_dbContext);
            this.CategoryAccess = new CategoryRepository(_dbContext);
            this.PriceAccess = new PriceRepository(_dbContext);
            this.SubCategoryAccess = new SubCategoryRepository(_dbContext);
            this.OrderAccess = new OrderRepository(_dbContext);
            this.RejectOrderAccess = new RejectOrderRepository(_dbContext);
            this.ReceiveOrderAccess = new ReceiveOrderRepository(_dbContext);
        }


        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
