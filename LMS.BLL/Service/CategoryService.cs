using LMS.BLL.Interface;
using LMS.BLL.Model;
using LMS.BLL.Repository;
using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Service
{
    public class CategoryService : GenericRepository<Category> , ICategoryService
    {

        GenericRepository<Category> _category = new GenericRepository<Category>();

        public List<CategoryDTO> GetAllCategories()
        {
            var listOfCategories = _category.GetAll();

            var listOfCategoryDTO = new List<CategoryDTO>();

            //Map from (List<Book>) to (List<BookDTO>)
            foreach (var item in listOfCategories)
            {
                var categoryDTO = new CategoryDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedOn = item.CreatedOn,
                    IsActive = item.IsActive,
                    Description = item.Description
                };
                listOfCategoryDTO.Add(categoryDTO);
            }

            return listOfCategoryDTO;
        }

        public CategoryDTO GetCategoryById(int id)
        {
            var category = _category.GetBy(id);

            //Map from (List<Category>) to (List<CategoryDTO>)

            var categoryDTO = new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name,
                CreatedOn = category.CreatedOn,
                IsActive = category.IsActive,
                Description = category.Description
            };

            return categoryDTO;
        }
        public void CreateCategory(CategoryDTO model)
        {
            //Map from (CategoryDTO) to (Category)

            var category = new Category()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Description = model.Description,
            };
            _category.Create(category);

        }
        public void UpdateCategory(CategoryDTO model)
        {
            //Map from (CategoryDTO) to (Category)

            var category = new Category()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Description = model.Description,
            };
            _category.Update(category);
        }
        public void DeleteCategory(CategoryDTO model)
        {
            //Map from (CategoryDTO) to (Category)

            var category = new Category()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Description = model.Description,
            };
            _category.Update(category);
        }
    }
}
