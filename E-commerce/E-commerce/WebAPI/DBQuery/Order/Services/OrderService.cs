using ecommerce.WebAPI.DBQuery.Order.Interfaces;
using ecommerce.WebAPI.DBQuery.Order.Services;

namespace ecommerce.WebAPI.DBQuery.Order.Services
{
    using ecommerce.Database.DBContext;
    using ecommerce.Models.Order.Models;

    /// <summary>
    /// 
    /// </summary>
    public class OrderService : IOrder
    {
        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public OrderService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<OrderService> _logger = loggerFactory.CreateLogger<OrderService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~OrderService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<Order?> GetOrderByIdAsync(Guid id)
        {

            Order? Order = await _appDbContext.Orders.FindAsync(id) ?? null;
            return Order;

        }

        public async Task<bool> CreateOrderAsync(Order Order)
        {
            try
            {
                await _appDbContext.Orders.AddAsync(Order);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateOrderAmountAsync(Guid id, float orderamount)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderAmount = orderamount;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderShipAddressAsync(Guid id, string shipaddress)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderShipAddress = shipaddress;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderShipAddress2Async(Guid id, string shipaddress)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderShipAddress2 = shipaddress;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderCityAsync(Guid id, string city)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderCity = city;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderStateAsync(Guid id, string state)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderState = state;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderZipAsync(Guid id, string zip)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderZip = zip;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderCountryAsync(Guid id, string country)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderCountry = country;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderPhoneAsync(Guid id, string phone)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderPhone = phone;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderFaxAsync(Guid id, string fax)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null) {
                Order.OrderFax = fax;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false; 
            }
        }

        public async Task<bool> UpdateOrderEmailAsync(Guid id, string email)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderEmail = email;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderShippedAsync(Guid id, byte shipped)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderShipped = shipped;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderTrackingNumberAsync(Guid id, string ordertrackingnumber)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                Order.OrderTrackingNumber = ordertrackingnumber;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderAsync(Guid id, Order _order)
        {
            Order? order = await GetOrderByIdAsync(id);

            if (order != null)
            {
                order.OrderAmount = _order.OrderAmount;
                order.OrderPhone = _order.OrderPhone;
                order.OrderShipped = _order.OrderShipped;
                order.OrderTrackingNumber = _order.OrderTrackingNumber;
                order.OrderEmail = _order.OrderEmail;
                order.OrderShipAddress = _order.OrderShipAddress;
                order.OrderShipAddress2 = _order.OrderShipAddress2;
                order.OrderZip = _order.OrderZip;
                order.OrderCity = _order.OrderCity;
                order.OrderCountry = _order.OrderCountry;
                order.OrderState = _order.OrderState;
                order.OrderTax = _order.OrderTax;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteOrderAsync(Guid id)
        {
            Order? Order = await GetOrderByIdAsync(id);

            if (Order != null)
            {
                _appDbContext.Orders.Remove(Order);
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
