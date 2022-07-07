﻿using DemoAcl.Infrastructure.DTOs;

namespace DemoAcl.Infrastructure.Repositories
{
    public interface IAmazonRepository
    {
        AmazonProductDto GetProductById(string Id);
    }
}
