namespace Lab08RonaldoCusi.DTOs;
public record ClientDto(int ClientId, string Name, string Email);
public record ProductDto(int ProductId, string Name, string? Description, decimal Price);
public record OrderDto(int OrderId, int ClientId, DateTime OrderDate);
public record ProductQuantityDto(string ProductName, int Quantity);
public record OrderWithDetailsDto(int OrderId, int ClientId, DateTime OrderDate, List<ProductQuantityDto> Details);
public record ClientOrderCountDto(int ClientId, string ClientName, int OrderCount);
public record ProductNameDto(string ProductName);
