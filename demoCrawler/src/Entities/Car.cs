using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace demoCrawler
{
    [DebuggerDisplay("{Model}, {Price}")]
    class Car
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
    }
}
