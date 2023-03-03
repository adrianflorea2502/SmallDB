using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectBD.DB;
using ProiectBD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Showcase.Web.Controllers
{


    public class MainViewController : Controller
    {
        private readonly proiectContext _context;

        public MainViewController(proiectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GameTemplate()
        {
            var pageData = await _context.Games.ToListAsync();
            List<StrangeGame> links = new();

            foreach (Game currentElement in pageData)
            {
                StrangeGame toAdd = new StrangeGame();

                toAdd.itemKey = currentElement.GameId;
                toAdd.name = currentElement.GameName;
                toAdd.releaseDate = (DateTime)currentElement.ReleaseDate;
                toAdd.developer = currentElement.DeveloperId;
                toAdd.publisher = currentElement.PublisherId;
                toAdd.price = (decimal)currentElement.Price;
                toAdd.rating = currentElement.Rating;
                toAdd.store_page = currentElement.StorePage;
                
                links.Add(toAdd);
                
            }

            if (links.Count > 0)
            {
                ViewData["1337"] = links;
            }

            return View();
        }
        public async Task<IActionResult> DeveloperTemplate()
        {
            var pageData = await _context.Developers.ToListAsync();
            List<StrangeDev> links = new();

            foreach (Developer currentElement in pageData)
            {
                StrangeDev toAdd = new StrangeDev();

                toAdd.itemKey = currentElement.DeveloperId;
                toAdd.name = currentElement.Name;
                toAdd.contact = currentElement.Contact;
                toAdd.country = currentElement.Country;

                links.Add(toAdd);
            }

            if (links.Count > 0)
            {
                ViewData["1338"] = links;
            }

            return View();
        }

        public async Task<IActionResult> PublisherTemplate()
        {
            var pageData = await _context.Publishers.ToListAsync();
            List<StrangePub> links = new();

            foreach (Publisher currentElement in pageData)
            {
                StrangePub toAdd = new StrangePub();

                toAdd.itemKey = currentElement.PublisherId;
                toAdd.name = currentElement.Name;
                toAdd.contact = currentElement.Contact;
                toAdd.country = currentElement.Country;

                links.Add(toAdd);
            }

            if (links.Count > 0)
            {
                ViewData["1339"] = links;
            }

            return View();
        }

        public async Task<IActionResult> UnderFiveTemplate()
        {
            var pageData = await _context.Games.ToListAsync();
            List<StrangeGame> links = new();

            foreach (Game currentElement in pageData)
            {
                if (currentElement.Price <= 5.0m)
                {
                    StrangeGame toAdd = new StrangeGame();

                    toAdd.itemKey = currentElement.GameId;
                    toAdd.name = currentElement.GameName;
                    toAdd.releaseDate = (DateTime)currentElement.ReleaseDate;
                    toAdd.developer = currentElement.DeveloperId;
                    toAdd.publisher = currentElement.PublisherId;
                    toAdd.price = (decimal)currentElement.Price;
                    toAdd.rating = currentElement.Rating;
                    toAdd.store_page = currentElement.StorePage;

                    links.Add(toAdd);
                }
                else
                {
                    continue;
                }
            }

            if (links.Count > 0)
            {
                ViewData["1335"] = links;
            }

            return View();
        }

        public async Task<IActionResult> ValveTemplate ()
        {
            var pageData = await _context.Games.ToListAsync();

            List<Game> games = _context.Games.FromSqlInterpolated($"exec GetGamesByPublisher {1}").ToList();

            if (games?.Count == 0)
            {
                games = new List<Game> { new Game { } };
            }

            if (games.Count > 0)
            {
                ViewData["lambda"] = games;
            }

            return View();
        }
    }
}

