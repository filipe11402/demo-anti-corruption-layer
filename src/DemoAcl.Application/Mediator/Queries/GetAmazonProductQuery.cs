using DemoAcl.Infrastructure.DTOs;
using ErrorOr;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetAmazonProductQuery : IRequest<ErrorOr<AmazonProductDto>>
    {
        public string Id { get; }

        public GetAmazonProductQuery(string id)
        {
            Id = id;
        }
    }
}
