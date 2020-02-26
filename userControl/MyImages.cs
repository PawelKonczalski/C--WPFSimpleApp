using System;
using System.Collections.Generic;
using System.IO;
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
            this.pathToImage = "logo-videokurspl.png";
            this.nameOfImage = "Logo";
        }
        public MyImages(string pathToImage, string nameOfImage)
        {
            this.pathToImage = pathToImage;
            this.nameOfImage = nameOfImage;


            isFound = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), pathToImage));
        }
    }
}
