using ecommerce.Database.DBContext;
using ecommerce.Models.Option.Models;
using ecommerce.Models.Order.Models;
using ecommerce.Models.Product.Models;
using ecommerce.WebAPI.DBQuery.Order.Interfaces;
using ecommerce.WebAPI.DBQuery.Product.Services;

namespace ecommerce.WebAPI.DBQuery.Order.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderDetailService : IOrderDetail
    {
        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public OrderDetailService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<OrderDetailService> _logger = loggerFactory.CreateLogger<OrderDetailService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~OrderDetailService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<OrderDetail?> GetOrderDetailByIdAsync(Guid id)
        {
            OrderDetail? OrderDetail = await _appDbContext.OrderDetails.FindAsync(id);
            return OrderDetail;
        }

        public async Task<bool> CreateOrderDetailAsync(OrderDetail orderDetail)
        {
            try
            {
                await _appDbContext.OrderDetails.AddAsync(orderDetail);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateOrderDetailNameAsync(Guid id, string detailname)
        {
            OrderDetail? OrderDetail = await GetOrderDetailByIdAsync(id);

            if (OrderDetail != null)
            {
                OrderDetail.DetailName = detailname;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderDetailPriceAsync(Guid id, float detailprice)
        {
            OrderDetail? OrderDetail = await GetOrderDetailByIdAsync(id);

            if (OrderDetail != null)
            {
                OrderDetail.DetailPrice = detailprice;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderDetailQuantityAsync(Guid id, uint detailquantity)
        {
            OrderDetail? OrderDetail = await GetOrderDetailByIdAsync(id);

            if (OrderDetail != null)
            {
                OrderDetail.DetailQuantity = detailquantity;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderDetailAsync(Guid id, OrderDetail _orderdetail)
        {
            OrderDetail? orderDetail = await GetOrderDetailByIdAsync(id);

            if (orderDetail != null)
            {
                orderDetail.DetailPrice = _orderdetail.DetailPrice;
                orderDetail.DetailQuantity = _orderdetail.DetailQuantity;
                orderDetail.DetailName = _orderdetail.DetailName;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteOrderDetailAsync(Guid id)
        {
            OrderDetail? OrderDetail = await GetOrderDetailByIdAsync(id);

            if (OrderDetail != null)
            {
                _appDbContext.OrderDetails.Remove(OrderDetail);
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
