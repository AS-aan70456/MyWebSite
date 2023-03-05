using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;
using TorrentMvcProject.Domain.Reposetory.interfeises;
using Microsoft.EntityFrameworkCore;

namespace TorrentMvcProject.Domain.Reposetory.RepModel{
    public class GameItemReposetory : IallGameItem {

        public AppDbContext context;

        public GameItemReposetory(AppDbContext context) {
            this.context = context;
        }

        public IEnumerable<GameItem> GetGameItem() {
            return context.GameItems;
        }

        public GameItem GetGameItemById(int id){
            return context.GameItems.FirstOrDefault(x => x.id == id);
        }

        public GameItem GetGameItemByName(string Name)
        {
            return context.GameItems.FirstOrDefault(x => x.name == Name);
        }

        public void DeleteGameItem(int id) {
            context.GameItems.Remove(new GameItem() {id = id});
        }

        public void SaveGameItem(GameItem newGameItem){
            if (newGameItem.id == default)
                context.Entry(newGameItem).State = EntityState.Added;
            else
                context.Entry(newGameItem).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
