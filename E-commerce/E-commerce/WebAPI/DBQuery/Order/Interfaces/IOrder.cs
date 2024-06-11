
namespace ecommerce.WebAPI.DBQuery.Order.Interfaces
{
    using ecommerce.Models.Order.Models;
    public interface IOrder
    {
        ///<get>
        
        ///<summary>
        /// Get order by id
        /// </summary>
        /// <param name="id">Order id</param>
        /// <returns>Order/null</returns>
        Task<Order?> GetOrderByIdAsync(Guid id);

        /// </get>
        
        ///<post>
        
        ///<summary>
        /// Create order
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>bool</returns>
        Task<bool> CreateOrderAsync(Order order);

        /// <summary>
        /// Update order amount
        /// </summary>
        /// <param name="id">Order id</param>
        /// <param name="orderamount">New order amount</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderAmountAsync(Guid id, float orderamount);

        /// <summary>
        /// Update order ship address
        /// </summary>
        /// <param name="id">Order id</param>
        /// <param name="shipaddress">New order ship address</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderShipAddressAsync(Guid id, string shipaddress);

        Task<bool> UpdateOrderShipAddress2Async(Guid id, string shipaddress);

        Task<bool> UpdateOrderCityAsync(Guid id, string city);

        Task<bool> UpdateOrderStateAsync(Guid id, string state);

        Task<bool> UpdateOrderZipAsync(Guid id, string zip);

        Task<bool> UpdateOrderCountryAsync(Guid id, string country);

        Task<bool> UpdateOrderPhoneAsync(Guid id, string phone);

        Task<bool> UpdateOrderFaxAsync(Guid id, string fax);

        Task<bool> UpdateOrderEmailAsync(Guid id, string email);

        Task<bool> UpdateOrderShippedAsync(Guid id, byte shipped);

        Task<bool> UpdateOrderTrackingNumberAsync(Guid id, string ordertrackingnumber);

        /// <summary>
        /// Update all order
        /// </summary>
        /// <param name="id">Order id</param>
        /// <param name="order">New order</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderAsync(Guid id, Order order);

        /// </post>

        ///<delete>

        Task<bool> DeleteOrderAsync(Guid id);
        
        /// </delete>
    }
}
