using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Reposetory.interfeises;
using TorrentMvcProject.Domain.Reposetory.RepModel;
using TorrentMvcProject.Domain;
using TorrentMvcProject.ViewModel;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.Controllers{
    public class GameController : Controller {

        public IallComments allComments { get; set; }
        public IallGameItem allGameItem { get; set; }
        public IallCategory allCategory { get; set; }

        public GameController(IallGameItem allGameItem, IallCategory allCategory, IallComments allComments)
        {
            this.allGameItem = allGameItem;
            this.allCategory = allCategory;
            this.allComments = allComments;
        }

        [HttpPost]
        [Route("Game/Game/{Name}")]
        public IActionResult Game(string Name, HomeViewModel modelResult){
            HomeViewModel model = new HomeViewModel(){
                allComment = allComments.GetComments().Where(i => i.GameName == Name),
                Game = allGameItem.GetGameItemByName(Name),
                newComment = new Comments()
            };

            allComments.SaveComments(new Comments() {
                Name = modelResult.newComment.Name,
                Gmail = modelResult.newComment.Gmail,
                Text = modelResult.newComment.Text,
                DataPost = DateTime.Now.ToString(),
                GameId = model.Game.id,
                GameName = model.Game.name,
            });
            model.newComment = new Comments();
            return View(model);
        }

        [Route("Game/Game/{Name}")]
        public IActionResult Game(string Name) {

            HomeViewModel model = new HomeViewModel() {
                allComment = allComments.GetComments().Where(i => i.GameName == Name),
                Game = allGameItem.GetGameItemByName(Name),
                newComment = new Comments()
            };

            return View(model);
        }

        

    }
}
