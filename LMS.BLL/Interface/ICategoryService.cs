using LMS.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface ICategoryService
    {

        public List<CategoryDTO> GetAllCategories();
        public CategoryDTO GetCategoryById(int id);

        public void CreateCategory(CategoryDTO model);
        public void UpdateCategory(CategoryDTO model);
        public void DeleteCategory(CategoryDTO model);
    }
}
