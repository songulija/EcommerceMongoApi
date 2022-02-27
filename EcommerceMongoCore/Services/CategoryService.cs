using EcommerceMongoCore.IServices;
using EcommerceMongoCore.Models;
using EcommerceMongoData.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceMongoCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoriesCollection;
        //through constructor getting EcommerceDatabaseSettings becouse its injected
        public CategoryService(IOptions<EcommerceDatabaseSettings> ecommerceDatabaseSettings)
        {
            //connecting to database
            var mongoClient = new MongoClient(
                ecommerceDatabaseSettings.Value.ConnectionString);
            //getting only our database
            var mongoDatabase = mongoClient.GetDatabase(
                ecommerceDatabaseSettings.Value.DatabaseName);
            _categoriesCollection = mongoDatabase.GetCollection<Category>(
                ecommerceDatabaseSettings.Value.CategoriesCollectionName);
        }
        public async Task<List<Category>> GetCategories()
        {
            return await _categoriesCollection.Find(_ => true).ToListAsync();
        }

        public Task<Category> GetCategory(string id)
        {
            return _categoriesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Category> CreateCategory(Category category)
        {
            await _categoriesCollection.InsertOneAsync(category);
            return category;
        }
        public async Task UpdateCategory(string id, Category category)
        {
            //first is filtering, then providing replacement
            await _categoriesCollection.ReplaceOneAsync(x => x.Id == id, category);
        }
        public async Task RemoveCategory(string id)
        {
            await _categoriesCollection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
