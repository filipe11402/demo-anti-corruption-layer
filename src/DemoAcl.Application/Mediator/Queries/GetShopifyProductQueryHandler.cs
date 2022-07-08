using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.Repositories;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetShopifyProductQueryHandler : IRequestHandler<GetShopifyProductQuery, ShopifyProductDto>
    {
        private readonly IShopifyRepository _shopifyRepository;

        public GetShopifyProductQueryHandler(IShopifyRepository shopifyRepository)
        {
            _shopifyRepository = shopifyRepository;
        }

        public Task<ShopifyProductDto> Handle(GetShopifyProductQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_shopifyRepository.GetProductById(request.Id));
        }
    }
}
