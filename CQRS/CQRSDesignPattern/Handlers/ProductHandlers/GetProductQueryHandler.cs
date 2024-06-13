using CQRS.CQRSDesignPattern.Results.ProductResults;
using CQRS.Dal.Context;

namespace CQRS.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x=> new GetProductQueryResult
            {
                ProductId = x.ProductId,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Stock = x.Stock,
                Price = x.Price,

            }).ToList();

            return values;
        }
    }
}
