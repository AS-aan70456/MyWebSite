using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Reposetory.interfeises;
using TorrentMvcProject.Domain.Reposetory.RepModel;
using TorrentMvcProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace TorrentMvcProject.Domain.Reposetory.RepModel{
    public class CategoryReposetory : IallCategory {

        public AppDbContext context;

        public CategoryReposetory(AppDbContext context) {
            this.context = context;
        }

        public IQueryable<Catagory> GetCategory(){
            return context.Categories;
        }

        public Catagory GetCategoryById(int id){
            return context.Categories.FirstOrDefault(x => x.id == id);
        }

        public void DeleteCategory(int id) {
            context.Categories.Remove(new Catagory() { id = id});
        }

        public void SaveCategory(Catagory newCategory) {
            if (newCategory.id == default){
                context.Entry(newCategory).State = EntityState.Added;
            }else {
                context.Entry(newCategory).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

    }
}
