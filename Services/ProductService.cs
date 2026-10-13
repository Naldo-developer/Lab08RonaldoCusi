using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Lab08RonaldoCusi.Services.Interfaces;
namespace Lab08RonaldoCusi.Services;
public class ProductService(IProductRepository repository) : IProductService
{
    public Task<List<ProductDto>> GetProductsAbovePriceExercise2Async(decimal precio, CancellationToken ct = default) =>
        repository.GetProductsAbovePriceExercise2Async(precio, ct);

    public Task<ProductDto?> GetMostExpensiveProductExercise5Async(CancellationToken ct = default) =>
        repository.GetMostExpensiveProductExercise5Async(ct);

    public Task<decimal?> GetAverageProductPriceExercise7Async(CancellationToken ct = default) =>
        repository.GetAverageProductPriceExercise7Async(ct);

    public Task<List<ProductDto>> GetProductsWithoutDescriptionExercise8Async(CancellationToken ct = default) =>
        repository.GetProductsWithoutDescriptionExercise8Async(ct);
}
