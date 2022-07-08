using DemoAcl.Infrastructure.DTOs;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetAmazonProductQuery : IRequest<AmazonProductDto>
    {
        public string Id { get; }

        public GetAmazonProductQuery(string id)
        {
            Id = id;
        }
    }
}
