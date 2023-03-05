using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.Domain.Reposetory.interfeises{
    public interface IallCategory {
        IQueryable<Catagory> GetCategory();
        Catagory GetCategoryById(int id);
        void SaveCategory(Catagory entity);
        void DeleteCategory(int id);
    }
}
