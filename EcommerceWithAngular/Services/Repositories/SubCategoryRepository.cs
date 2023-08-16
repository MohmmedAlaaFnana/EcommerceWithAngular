using EcommerceWithAngular.Data;
using EcommerceWithAngular.Models;
using EcommerceWithAngular.Services.Infrastructures;

namespace EcommerceWithAngular.Services.Repositories
{
    public class SubCategoryRepository : ISubCategory
    {
        private ApplicationDbContext _context;

        public SubCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.SubCategories.Count();
        }

        public void Delete(int id)
        {
            var subCategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subCategory != null)
            {
                _context.SubCategories.Remove(subCategory);
            }
        }
        public SubCategory GetSubCategory(int id)
        {
            var subCategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subCategory != null)
            {
                return subCategory;
            }
            return null;
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return _context.SubCategories;
        }

        public void Insert(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
        }
    }
}
