using Control_Panel.Data.Models;

namespace Control_Panel.Repositories.Interface
{
    public interface IItemRepository
    {
        Task<Item> CreateAsync(Item blogPost);

        Task<IEnumerable<Item>> GetAllAsync();

        Task<Item?> GetByIdAsync(Guid id);
      

        Task<Item?> UpdateAsync(Item blogPost);

        Task<Item?> DeleteAsync(Guid id);
    }
}
