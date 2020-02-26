using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTriggers
{
    class MyImages
    {
        public string pathToImage { get; set; }
        public string nameOfImage { get; set; }
        public bool isFound { get; set; }

        public MyImages()
        {
            this.pathToImage = "logo.png";
            this.nameOfImage = "Logo";
        }
    }
}
