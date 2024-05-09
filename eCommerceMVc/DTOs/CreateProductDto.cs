namespace eCommerceMVc.DTOs;

public sealed class CreateProductDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Price {  get; set; } = string.Empty;
    public IFormFile? File {  get; set; }
}
    
    

