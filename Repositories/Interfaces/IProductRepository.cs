using Lab08RonaldoCusi.DTOs;
namespace Lab08RonaldoCusi.Repositories.Interfaces;
public interface IProductRepository
{
    Task<List<ProductDto>> GetProductsAbovePriceExercise2Async(decimal precio, CancellationToken ct = default);
    Task<ProductDto?> GetMostExpensiveProductExercise5Async(CancellationToken ct = default);
    Task<decimal?> GetAverageProductPriceExercise7Async(CancellationToken ct = default);
    Task<List<ProductDto>> GetProductsWithoutDescriptionExercise8Async(CancellationToken ct = default);
}
