using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.Repositories;
using ErrorOr;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetShopifyProductQueryHandler : IRequestHandler<GetShopifyProductQuery, ErrorOr<ShopifyProductDto>>
    {
        private readonly IShopifyRepository _shopifyRepository;

        public GetShopifyProductQueryHandler(IShopifyRepository shopifyRepository)
        {
            _shopifyRepository = shopifyRepository;
        }

        public Task<ErrorOr<ShopifyProductDto>> Handle(GetShopifyProductQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_shopifyRepository.GetProductById(request.Id));
        }
    }
}
