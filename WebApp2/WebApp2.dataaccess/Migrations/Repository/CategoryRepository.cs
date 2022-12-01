using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp2.dataaccess.Data;
using WebApp2.dataaccess.Migrations.Repository.IRepository;
using WebApp2.models;

namespace WebApp2.dataaccess.Migrations.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.Category.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
}
        public void Update(Category category)
        {
            var objFromDb = _db.Category.FirstOrDefault(s => s.Id == category.Id);
            objFromDb.DisplayOrder = category.DisplayOrder;

            _db.SaveChanges();

        }   
    }
}
