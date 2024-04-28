using Control_Panel.Data.Models;

namespace Control_Panel.Repositories.Interface
{
    public interface IImageItemRepository
    {
        Task<ItemImage> Upload(IFormFile file, ItemImage blogImage);

        Task<IEnumerable<ItemImage>> GetAll();
    }
}
