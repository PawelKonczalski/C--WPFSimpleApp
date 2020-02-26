using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTriggers
{
    public class MyImages
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

            string absolutePathToSource = Path.Combine(Directory.GetCurrentDirectory(), pathToImage);
            this.pathToImage = absolutePathToSource;
            this.nameOfImage = nameOfImage;


            isFound = File.Exists(absolutePathToSource);
        }
    }
}
