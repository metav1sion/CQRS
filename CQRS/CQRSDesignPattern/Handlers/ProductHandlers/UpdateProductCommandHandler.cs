using CQRS.CQRSDesignPattern.Command.ProductCommands;
using CQRS.Dal.Context;

namespace CQRS.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;
        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductId);
            if (value != null)
            {
                value.ProductName = command.ProductName;
                value.Description = command.Description;
                value.ImageUrl = command.ImageUrl;
                value.Stock = command.Stock;
                value.Price = command.Price;
                value.CategoryId = command.CategoryId;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Değer boş.");
            }
        }

    }
}
