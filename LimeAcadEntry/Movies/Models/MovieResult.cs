using System.Collections.Generic;

namespace Movies.Models
{
    public class MovieResult
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public List<Movie> Data { get; set; }
    }
}