using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Reposetory.interfeises;
using TorrentMvcProject.ViewModel;
using TorrentMvcProject.Domain.Entity;
using TorrentMvcProject.Service;

namespace TorrentMvcProject.Controlers{
    public class HomeController : Controller{

        public IallGameItem allGameItem { get; set; }
        public IallCategory allCategory { get; set; }


        public HomeController(IallGameItem allGameItem, IallCategory allCategory){
            this.allCategory = allCategory;
            this.allGameItem = allGameItem;
        }
        [Route("Home/Home")]
        [Route("Home/Home/{ID}")]
        public ViewResult Home(int ID){
            if (ID == null)ID = 0;

            GameViewModel model = new GameViewModel(){
                _allGameItems = allGameItem.GetGameItem()
            };
            model._allGameItems = PageMeneger.PegeSelect(model._allGameItems, 12, ID);


            ViewBag.ID = ID;
            ViewBag.next = "/Home/Home/" + (ID + 1);
            ViewBag.back = "/Home/Home/" + (ID - 1);

            return View(model);
        }
        [Route("Home/Category/{Category}")]
        [Route("Home/Category/{Category}/{ID}")]
        public ViewResult Category(string Category, int ID){
            if (ID == null) ID = 0;
            IEnumerable<GameItem> games = null;
            

            if (string.IsNullOrEmpty(Category)){
                games = allGameItem.GetGameItem();
            }else{
                games = allGameItem.GetGameItem().Where(i => TegConstact.CheckMatches(TegConstact.TegsToStringArrey(i.teg), Category));
            }

            GameViewModel model = new GameViewModel(){
                _allGameItems = games
            };

            model._allGameItems = PageMeneger.PegeSelect(model._allGameItems, 12, ID);
            ViewBag.ID = ID;
            ViewBag.next = "/Home/Category/" + Category + "/" + (ID + 1);
            ViewBag.back = "/Home/Category/" + Category + "/" + (ID - 1);

            return View(model);
        }
        [Route("Home/Leyer/{leyer}")]
        [Route("Home/Leyer/{leyer}/{ID}")]
        public ViewResult Leyer(int leyer, int ID){
            if (ID == null)ID = 0;

            IEnumerable<GameItem> games = null;
            games = allGameItem.GetGameItem().Where(i => i.ReleaseDate == leyer);

            GameViewModel model = new GameViewModel() {
                _allGameItems = games
            };
            model._allGameItems = PageMeneger.PegeSelect(model._allGameItems, 12, ID);

            ViewBag.ID = ID;
            ViewBag.next = "/Home/Leyer/" + leyer + "/" + (ID + 1);
            ViewBag.back = "/Home/Leyer/" + leyer + "/" + (ID - 1);

            return View(model);
        }

        [Route("Home/Search/{search}")]
        [Route("Home/Search/{search}/{ID}")]
        public ViewResult Search(string search, int ID){
            if (ID == null) ID = 0;
            

            GameViewModel model = new GameViewModel(){
                _allGameItems = allGameItem.GetGameItem().Where(i => i.name.ToLower() == search.ToLower())
            };

            model._allGameItems = PageMeneger.PegeSelect(model._allGameItems, 12, ID);

            ViewBag.ID = ID;
            ViewBag.next = "/Home/Search/" + search + "/" + (ID + 1);
            ViewBag.back = "/Home/Search/" + search + "/" + (ID - 1);


            return View(model);
        }
    }
}
