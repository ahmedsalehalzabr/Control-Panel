using Control_Panel.Data.Models;

namespace Control_Panel.Repositories.Interface
{
    public interface IImageCategoryRepository
    {
        Task<CategoryIamge> Upload(IFormFile file, CategoryIamge blogImage);

        Task<IEnumerable<CategoryIamge>> GetAll();
    }
}
