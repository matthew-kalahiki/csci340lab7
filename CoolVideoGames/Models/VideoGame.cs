using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CoolVideoGames.Models
{
	public class VideoGame
	{
        public int ID { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
