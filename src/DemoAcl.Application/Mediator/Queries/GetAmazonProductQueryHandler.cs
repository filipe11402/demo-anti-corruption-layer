using DemoAcl.Infrastructure.DTOs;
using DemoAcl.Infrastructure.Repositories;
using MediatR;

namespace DemoAcl.Application.Mediator.Queries
{
    public class GetAmazonProductQueryHandler : IRequestHandler<GetAmazonProductQuery, AmazonProductDto>
    {
        private readonly IAmazonRepository _amazonRepository;

        public GetAmazonProductQueryHandler(IAmazonRepository amazonRepository)
        {
            _amazonRepository = amazonRepository;
        }

        public Task<AmazonProductDto> Handle(GetAmazonProductQuery request, CancellationToken cancellationToken)
        {
            return  Task.FromResult(_amazonRepository.GetProductById(request.Id));
        }
    }
}
