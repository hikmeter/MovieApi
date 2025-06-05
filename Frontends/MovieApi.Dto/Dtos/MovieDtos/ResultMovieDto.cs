using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Dto.Dtos.MovieDtos
{
    public class ResultMovieDto
    {
        public int movieId { get; set; }
        public string title { get; set; }
        public string coverImageUrl { get; set; }
        public decimal rating { get; set; }
        public string description { get; set; }
        public int duration { get; set; }
        public DateTime releaseDate { get; set; }
        public string createdYear { get; set; }
        public bool status { get; set; }
    }
}
