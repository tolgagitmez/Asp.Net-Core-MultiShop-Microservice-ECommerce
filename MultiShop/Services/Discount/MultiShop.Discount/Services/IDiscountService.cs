using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponsAsync();

        Task CreateDiscountCouponAsync(CreateDiscountCouponDto coupon);

        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto coupon);

        Task DeleteDiscountCouponAsync(int id);

        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);


    }
}
