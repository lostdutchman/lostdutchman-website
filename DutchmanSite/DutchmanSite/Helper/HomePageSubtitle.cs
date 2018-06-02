using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutchmanSite.Helper
{
    public class HomePageSubtitle
    {
        private List<string> SubtitleList = new List<string> {
                "Whisper your secrets to us",
                "We're Trapped!",
                "From a lost city, hundreds of miles below the Superstition Mountains",
                "I'm supposted to use this line to convince you to buy our products",
                "We'll argue about anything",
                "Live from an isolated gulch under a full moon!",
                "Doing....Something..",
                "We dont even know what we do",
                "A form of bussiness that consists of buzzwords, esoteric code, and incomprehensable design",
                "Powered by crystals!",
                "The interpolation mode also joins or breaks left and right tangents",
                "We're winning the Arms Race",
                "Lorem ipsum dolor sit amet"
        };

        public string GetSubtitle()
        {
            Random Rand = new Random();
            return SubtitleList[Rand.Next(0, SubtitleList.Count)];
        }
    }
}