namespace EmptyWebApi.ViewModels
{
    public class GetProductsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ProductTypeId { get; set; }
        public GetProductsProductTypeVM ProductType { get; set; }
    }

    public class GetProductsProductTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}