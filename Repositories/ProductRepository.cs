using Lab08RonaldoCusi.Data;
using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Lab08RonaldoCusi.Repositories;
public class ProductRepository(AppDbContext context) : IProductRepository
{
    public Task<List<ProductDto>> GetProductsAbovePriceExercise2Async(decimal precio, CancellationToken ct = default) =>
        context.Products.AsNoTracking().Where(p => p.Price > precio).Select(p => new ProductDto(p.Productid,p.Name,p.Description,p.Price)).ToListAsync(ct);

    public Task<ProductDto?> GetMostExpensiveProductExercise5Async(CancellationToken ct = default) =>
        context.Products.AsNoTracking().OrderByDescending(p => p.Price).ThenBy(p => p.Productid).Select(p => new ProductDto(p.Productid,p.Name,p.Description,p.Price)).FirstOrDefaultAsync(ct);

    public Task<decimal?> GetAverageProductPriceExercise7Async(CancellationToken ct = default) =>
        context.Products.AsNoTracking().Select(p => (decimal?)p.Price).AverageAsync(ct);

    public Task<List<ProductDto>> GetProductsWithoutDescriptionExercise8Async(CancellationToken ct = default) =>
        context.Products.AsNoTracking().Where(p => p.Description == null || p.Description == "").Select(p => new ProductDto(p.Productid,p.Name,p.Description,p.Price)).ToListAsync(ct);
}
