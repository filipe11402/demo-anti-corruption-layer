# Anti-Corruption layer/pattern demonstration

This project showcases an example of when a given software needs to communicate with third party services to fetch read-only data, and then apply some domain logic to it.

## Patterns used
- CQRS(in this case only the query stack was used to prove a point)
- Repository
- Anti-corruption

## Context
Imagine you have a system, on which you have the hability to show to your users all their products that they have on Shopify and Amazon. But, each platform returns different data structures to represent their products through their API's. And even worse, your domain experts normally make certain calculations on top of the products from each platform!

## Constraints

### Amazon
The users when getting Amazon products, should see:
- Product Id
- Product name
- Price

What Amazon API returns:
- Product Id
- Product name
- Product discount
- Product price with tax
- Product selling country

But the thing here is, Amazon API only gives retrieves the producs with their price + tax of the country on which the country is beeing sold, and our domain experts want to show the price without tax included. What shall we do?
As you can see, we have the selling country and the price with tax, we can easily calculate the needed value, by applying some business logic...and for that, we created a domain service ``ICountryPriceCalculator<T>``, that is responsible for that.

### Shopify
The users when getting Shopify products, should see:
- Product Id
- Product name
- Product price
- Product Profit

What Shopify API returns:
- Product Id
- Product name
- Product price
- Product Store name
- Product Comission

Where's the catch here now?
We need the profit...but the API doesn't return that!
But, after talking with our domain experts and informing them of what Shopify gives us, they said **"Oh that's easy, we just need to calculate the profit, by doing the price - comission".** With that said, we created a domain service that deals with this ``IProfitCalculator<T>``.

## Explanations
**Why Domain services and not domain models?**
My reason, is because we are reading data from a third party, and the Domain model in my perspective, is responsible of applying domain logic when we are changing the state of something, In this case, this data is read-only, ence the Domain services and the DTO's.

**Why the Repository Pattern in this case?**
If we think about it, we are reading data from another data source, aren't we?
And this pattern is used, normally when getting data from a data source.
But, since this is an Anti-Corruption layer, we can also consider this as the Ports and Adapters, as the Hexagonal architechture says.


## Sources
[Martin fowler](https://martinfowler.com/articles/refactoring-external-service.html)
[Alistair Cockburn](https://alistair.cockburn.us/hexagonal-architecture/)
[CQRS](https://docs.microsoft.com/en-us/archive/msdn-magazine/2016/march/cutting-edge-the-query-stack-of-a-cqrs-architecture)