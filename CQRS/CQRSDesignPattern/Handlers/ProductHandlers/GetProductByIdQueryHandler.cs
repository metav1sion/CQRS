using CQRS.CQRSDesignPattern.Queries.ProductQueries;
using CQRS.CQRSDesignPattern.Results.ProductResults;
using CQRS.Dal.Context;

namespace CQRS.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.ProductId);
            return new GetProductByIdQueryResult
            {
                ProductId = value.ProductId,
                ProductName = value.ProductName,
                Description = value.Description,
                ImageUrl = value.Description,
                Stock = value.Stock,
                Price = value.Price,
                CategoryId = value.CategoryId
            };
        }
    }
}
