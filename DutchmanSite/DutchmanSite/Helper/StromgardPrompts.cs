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
                "Dry-roasted, flavorless wild caught RPG's",
                "Precipitation: 0%",
                "https://libraryofbabel.info/bookmark.cgi?b.ieufd.yhajrw.o182",
                "The voice of a cat being pet”",
                "I <3 C# Lists",
                "Don't let me forget to pick up some Jalapenos on the way home",
                "It's pronounced Mango!",
                "The good stuffs further down",
                "We won't tell",
                "Do you know what happens when you burn a lock of their hair?",
                "Doing business with Cryptids",
                "Mothman sold me a bike behind Filiberto's",
                "Profound feeling of Desert Melancholy",
                "A heavy moon hangs low over the saguaros",
                "The business end of a Jumping Cholla",
                "Did you know that scorpions glow under UV light? It's proof of their sins.",
                "Did you know that Arizona has two distinct seasons?  Hot and Angry Hot.",
                "If insomnia had its own website.",
                "You chose... wisely.",
                "Wisdom of the ancients",
                "Serving shade and looks since 2017",
                "Over 10 people served!",
                "Throw your head back and scream",
                "Our favorite color is puce",
                "Now you're cursed",
                "The Jersey Devil drinks fruit tea",
                "I miss the clam chowder by the ferry terminal",
                "Scarab beetles are crunchy bugs",
                "When cats look around the room all crazy-like",
                "Getting worked up about art",
                "A random subtitle to hide the fact that we can't come up with a good one"
        };

        public string GetSubtitle()
        {
            Random Rand = new Random();
            return SubtitleList[Rand.Next(0, SubtitleList.Count)];
        }
    }
}