using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcWebApplicationMucisStore.Models
{
    public class Songs
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]


        public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; }
            public string ImagePath { get; set; }
            public decimal Price { get; set; }
        }
    }

