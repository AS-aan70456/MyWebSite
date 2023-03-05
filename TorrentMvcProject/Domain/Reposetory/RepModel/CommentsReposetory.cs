using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;
using TorrentMvcProject.Domain.Reposetory.interfeises;
using Microsoft.EntityFrameworkCore;

namespace TorrentMvcProject.Domain.Reposetory.RepModel{
    public class CommentsReposetory : IallComments{

        public AppDbContext context;

        public CommentsReposetory(AppDbContext context) {
            this.context = context;
        }

        public IEnumerable<Comments> GetComments(){
            return context.Comments;
        }

        public Comments GetCommentsById(int id){
            return context.Comments.FirstOrDefault(i => i.id == id);
        }

        public void DeleteComments(int id){
            context.Comments.Remove(new Comments() { id = id });
            context.SaveChanges();
        }

        public void SaveComments(Comments newGameItem){
            if (newGameItem.id == default)
                context.Entry(newGameItem).State = EntityState.Added;
            else 
                context.Entry(newGameItem).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Comments GetCommentsName(string Name){
            return context.Comments.FirstOrDefault(i => i.Name == Name);
        }
    }
}
