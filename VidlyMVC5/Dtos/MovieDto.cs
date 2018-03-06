using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyMVC5.Models;

namespace VidlyMVC5.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte StockQty { get; set; }

        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}