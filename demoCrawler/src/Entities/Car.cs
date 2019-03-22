using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.ComponentModel.DataAnnotations;

namespace demoCrawler
{

    [DebuggerDisplay("{Model}, {Price}")]
    class Car
    {
        [Key]
        public long? Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
    }
}
