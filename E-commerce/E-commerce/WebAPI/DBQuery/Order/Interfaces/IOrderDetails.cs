using ecommerce.Models.Order.Models;

namespace ecommerce.WebAPI.DBQuery.Order.Interfaces
{
    public interface IOrderDetail
    {
        ///<get>

        ///<summary>
        ///Get order detail
        /// </summary>
        /// <param name="id">Order detail id</param>
        /// <returns>OrderDetail/null</returns>
        Task<OrderDetail?> GetOrderDetailByIdAsync(Guid id);

        /// </get>

        ///<post>

        ///<summary>
        ///Create order detail
        /// </summary>
        /// <param name="orderDetail">Order detail</param>
        /// <returns>bool</returns>
        Task<bool> CreateOrderDetailAsync(OrderDetail orderDetail);

        /// <summary>
        /// Update order detail name
        /// </summary>
        /// <param name="id">Order detail id</param>
        /// <param name="detailname">New order detail name</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderDetailNameAsync(Guid id, string detailname);

        /// <summary>
        /// Update order detail price
        /// </summary>
        /// <param name="id">Order detail id</param>
        /// <param name="detailprice">New order detail price</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderDetailPriceAsync(Guid id, float detailprice);

        /// <summary>
        /// Update order detail quantity
        /// </summary>
        /// <param name="id">Order detail id</param>
        /// <param name="detailquantity">New order detail quantity</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderDetailQuantityAsync(Guid id, uint detailquantity);

        /// <summary>
        /// Update all order
        /// </summary>
        /// <param name="id">Order id</param>
        /// <param name="orderdetail">New order detail</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOrderDetailAsync(Guid id, OrderDetail orderdetail);

        /// </post>

        ///<delete>

        ///<summary>
        /// Delete order detail
        /// </summary>
        /// <param name="id">Order detail id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteOrderDetailAsync(Guid id);

        /// </delete>
    }
}
