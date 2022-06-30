using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDM4
{
    public class MovieModel
    {
        public string Id { get; set; }
        public string MovieName { get; set; }
        public string ReleaseYear { get; set; }

        public string MovieInfo
        {
            get
            {
                return $"{MovieName} | {ReleaseYear}";
            }
        }
    }
}
