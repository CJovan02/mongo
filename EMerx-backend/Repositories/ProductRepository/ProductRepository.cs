using EMerx_backend.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EMerx_backend.Repositories.ProductRepository;

public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<Product> _products;

    public ProductRepository(IMongoClient mongoClient, IConfiguration config)
    {
        var database = mongoClient.GetDatabase(config["MongoDb:DatabaseName"]);
        _products = database.GetCollection<Product>("Products");
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetProductById(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public async Task CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteProduct(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}