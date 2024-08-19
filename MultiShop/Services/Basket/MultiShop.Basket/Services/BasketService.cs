using MultiShop.Basket.Dtos;
using MultiShop.Basket.Settings;
using System.Text.Json;

namespace MultiShop.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task DeleteBasket(string userId)
        {
            await _redisService.GetDb().KeyDeleteAsync(userId);
        }

        public async Task<BasketTotalDto> GetBasket(string userId)
        {
            //var existBasket = await _redisService.GetDb().StringGetAsync(userId);
            //return JsonSerializer.Deserialize<BasketTotalDto>(existBasket);
            var existBasket = await _redisService.GetDb().StringGetAsync(userId);
            if (existBasket.IsNullOrEmpty)
            {
                Console.WriteLine($"No basket found for userId: {userId}");
                return null;
            }
            try
            {
                return JsonSerializer.Deserialize<BasketTotalDto>(existBasket);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Deserialization failed: {ex.Message}");
                throw;
            }
        }

        public async Task SaveBasket(BasketTotalDto basketTotalDto)
        {
            //await _redisService.GetDb().StringSetAsync(basketTotalDto.UserId, JsonSerializer.Serialize(basketTotalDto));
            var serializedBasket = JsonSerializer.Serialize(basketTotalDto);
            await _redisService.GetDb().StringSetAsync(basketTotalDto.UserId, serializedBasket);
        }
    }
}
