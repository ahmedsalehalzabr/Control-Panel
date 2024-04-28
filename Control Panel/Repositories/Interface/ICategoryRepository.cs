using Control_Panel.Data.Models;

namespace Control_Panel.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);

        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category?> GetById(Guid id);
        Task<Category?> GetByIdHandleAsync(string urlHandle);
        Task<Category> UpdateAsync(Category category);

        Task<Category?> DeleteAsync(Guid id);
    }
}
