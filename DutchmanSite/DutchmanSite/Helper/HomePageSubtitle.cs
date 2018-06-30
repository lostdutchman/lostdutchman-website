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
                "I'm supposed to use this line to convince you to buy our products",
                "We'll argue about anything",
                "Live from an isolated gulch under a full moon!",
                "Doing....Something..",
                "We don't even know what we do",
                "A form of business that consists of buzzwords, esoteric code, and incomprehensible design",
                "Powered by crystals!",
                "The interpolation mode also joins or breaks left and right tangents",
                "'Winning' the Arms Race",
                "Lorem ipsum dolor sit amet",
                "I like your shirt",
                "Dry-roasted flavorless wild caught RPG's",
                "Precipitation: 0%",
                "https://libraryofbabel.info/bookmark.cgi?found_it:5",
                "The voice of a cat being pet”",
                "I <3 C# Lists",
                "Don't let me forget to pick up some Jalapenos on the way home",
                "It's pronounced Mango!",
                "The good stuffs further down",
                "We won't tell"

        };

        public string GetSubtitle()
        {
            Random Rand = new Random();
            return SubtitleList[Rand.Next(0, SubtitleList.Count)];
        }
    }
}