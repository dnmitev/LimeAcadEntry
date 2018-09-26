using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Flurl;
using Flurl.Http;
using Movies.Models;
using System.Linq;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private string urlWithPaging = "https://jsonmock.hackerrank.com/api/movies/search/?Title={0}&page={1}";

        [HttpGet]
        public async Task<IEnumerable<string>> Get(string title)
        {
            List<string> titles = new List<string>();
            int page = 1;

            var query = await string.Format(urlWithPaging, title, page)
                .GetJsonAsync<MovieResult>()
                .ConfigureAwait(false);

            query.Data.ForEach(d => titles.Add(d.Title));
                
            if (query.Total_pages > 1)
            {
                int currentPage = 2;
                while (currentPage <= query.Total_pages)
                {
                    var currentData = await string.Format(urlWithPaging, title, currentPage)
                        .GetJsonAsync<MovieResult>()
                        .ConfigureAwait(false);

                    currentData.Data.ForEach(d => titles.Add(d.Title));
                    currentPage++;
                }
            }

            return titles.OrderBy(q => q);
        }
    }
}
