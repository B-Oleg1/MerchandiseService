namespace MerchandiseService.Models
{
    public class MerchItemCreationModel
    {
        public long RequestNumber { get; init; }

        public string EmployeeName { get; init; }

        public string ItemName { get; init; }

        public int ItemType { get; init; }
        
        public int ClothingSize { get; init; }
        
        public int Quantity { get; init; }
    }
}