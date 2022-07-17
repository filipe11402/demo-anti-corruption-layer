using DemoAcl.Infrastructure.DTOs;
using ErrorOr;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetShopifyProductQuery : IRequest<ErrorOr<ShopifyProductDto>>
    {
        public string Id { get; }

        public GetShopifyProductQuery(string id)
        {
            Id = id;
        }
    }
}
