using DemoAcl.Infrastructure.DTOs;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetShopifyProductQuery : IRequest<ShopifyProductDto>
    {
        public string Id { get; }

        public GetShopifyProductQuery(string id)
        {
            Id = id;
        }
    }
}
