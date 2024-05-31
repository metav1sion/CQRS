namespace CQRS.CQRSDesignPattern.Command.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
