using EcommerceMongoData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceMongoCore.IServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(string id);
        Task<Category> CreateCategory(Category category);
        Task UpdateCategory(string id, Category category);
        Task RemoveCategory(string id);

       
    }
}
