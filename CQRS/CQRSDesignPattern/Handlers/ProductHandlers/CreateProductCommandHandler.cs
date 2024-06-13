using CQRS.CQRSDesignPattern.Command.ProductCommands;
using CQRS.Dal.Context;
using CQRS.Dal.Entities;

namespace CQRS.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handler(CreateProductCommand createProductCommand)
        {
            Product urun = new Product
            {
                ProductName = createProductCommand.ProductName,
                Description = createProductCommand.Description,
                ImageUrl = createProductCommand.ImageUrl,
                Stock = createProductCommand.Stock,
                Price = createProductCommand.Price,
                CategoryId = createProductCommand.CategoryId
            };

            // Ürün ekleme işlemi
            _context.Products.Add(urun);
            // Değişiklikleri kaydetme işlemi
            _context.SaveChanges(); 
        }
    }
}
