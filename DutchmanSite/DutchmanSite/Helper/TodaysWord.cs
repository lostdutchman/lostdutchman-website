using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace DutchmanSite.Helper
{
    public class TodaysWord
    {
        #region Language Strings
        #region Japanese
        private List<string> Japanese = new List<string> {
                "kyo ka sho. kyo ka sho means textbook.",
                "yoo bee.  yoo bee means finger.",
                "o ka shee.  o ka shee means weird.",
                "toe ri koo mi.  toe ri koo me means soo mo bout.",
                "ah mah ee.  ah mah ee means sweet.",
                "ni chee yo bee. ni chee yo bee means Sunday.",
                "ah kee.  ah kee means autumn.",
                "doe yo bee.  doe yo bee means Saturday.",
                "kyo ryo koo.  kyo ryo koo means powerful.",
                "kah shee ko shee.  kah shee ko shee means wise.",
                "tow ko ro. tow ko ro means place.",
                "moe koo yo bee.  moe koo yo bee means Thursday.",
                "sho set su.  sho set su means story.",
                "koo su ree.  koo su ree means medicine.",
                "koo sah ee.  koo sah ee means stinky.",
                "soo ee yo bee.  soo ee yo bee means Wednesday.",
                "keh ee saat su kaan.  keh ee saat su kaan means police officer.",
                "ha zoo kah shee.  ha zoo kah shee means embarassing.",
                "kah yo bee.  kah yo bee means Tuesday.",
                "koo chee.  koo chee means mouth.",
                "shee ko doe.  shee ko doe means job.",
                "gaan ko.  gaan ko means stubborn.",
                "su pa ee.  su pa ee means sour.",
                "o so ee. o so ee means slow.",
                "ee nu. ee nu means dog.",
                "teh ni su. teh ni su means tennis.",
                "me zoo.  me zoo means water.",
                "hon. hon means book.",
                "gaah koo sei.  gaah koo sei means student.",
                "tori.  tori means bird.",
                "sah kahna.  sah kahna means fish.",
                "hee toe.  hee toe means person.",
                "toe moe dah chee.  toe moe dah chee means friend.",
                "gah koe. gah koe means school.",
                "wah koo sei.  wah koo sei means planet.",
                "o cha.  o cha means tea.",
                "koh doe mo.  koh doe mo means child.",
                "jee kahn.  jee kahn means time.",
                "ohayo go zai mahss.  ohayo go zai mahss means good morning.",
                "get su yo bee.  get su yo bee means Monday.",
                "kee no.  kee no means yesterday.",
                "konnichiwa.  konnichiwa means hello.",
                "yo ru.  yo ru means night.",
                "aash ta.  aash ta means tomorrow.",
                "koe koe.  koe koe means here.",
                "moe moe.  moe moe means peach.",
                "kah wah ee.  kah wah ee means cute.",
                "ee so gah shee.  ee so gah shee means busy.",
                "oya sumi nasai. oya sumi nasai means good night.",
                "neeku. neeku means meat.",
                "konbanwa.  konbanwa means good evening.",
                "yasui.  yasui means vegetable",
                "koo da sai.  koo da sai means please.",
                "ta bay moe no. ta bay moe no means food.",
                "soo me mah sen.  soo me mah sen means excuse me.",
                "boo dough. boo dough means grape.",
                "denwa.  denwa means telephone.",
                "ee sha. ee sha means doctor.",
                "ari gato go zai mahss.  ari gato go zai mahss means thank you very much.",
                "shin boon.  shin boon means newspaper.",
                "densha.  densha means train.",
                "koe hee.  koe hee means coffee.",
                "hai.  hai means yes.",
                "doe boot su.  doe boot su means animal",
                "ah na ta.  an na ta means you.",
                "aaht su ee.  aaht su ee means hot.",
                "haaru.  haaru means spring.",
                "ee eh.  ee eh means no.",
                "saan.  saan means mister or misses at the end of someone's name.",
                "watashi.  watashi means I.",
                "natsu.  natsu means summer.",
                "ah may.  ah may meains rain.",
                "tamago.  tamago means egg.",
                "yuki.  yuki means snow.",
                "oomi. oomi means ocean.",
                "fooyu.  fooyu means winter.",
                "ee chee go.  ee chee go means strawberry.",
                "mee kaan.  mee kaan means tangerine.",
                "mahdo.  mahdo means window.",
                "ehga.  ehga means movie.",
                "ongaku.  ongaku means music.",
                "ah saa go han.  ah saa go han means breakfast.",
                "saa ru.  saa ru means monkey.",
                "oo saa gi. oo saa gi means rabbit.",
                "ringo.  ringo means apple.",
                "sora. sora means sky.",
                "tai yo.  tai yo means sun.",
                "hana.  hana means flower.",
                "shima. shima means island.",
                "issu.  issu means chair.",
                "haashi. haashi means chopsticks.",
                "saa mui. saa mui means cold.",
                "ni wah. ni wah means garden.",
                "koo ko. koo ko means airport.",
                "maat su ree.  maat su ree means festival.",
                "oh kah saan. oh kah saan means mother.",
                "moo soo ko. moo soo ko means son.",
                "aaka. aaka means red.",
                "oh toe saan.  oh toe saan means father.",
                "moo soo me. moo soo me means daughter.",
                "kuro.  kuro means black."
        };
        #endregion
        #region Spanish
        private List<string> Spanish = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #region French
        private List<string> French = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #region Italian
        private List<string> Italian = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #region German
        private List<string> German = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #endregion

        public string jsonBuilder(string language)
        {
            Dictionary<string, string> Word = new Dictionary<string, string>();
            Word.Add("uid", Guid.NewGuid().ToString());
            Word.Add("updateDate", DateTime.Today.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Word.Add("titleText", "Today's " + language);
            Word.Add("mainText", WordOfTheDay(language));
            Word.Add("redirectionUrl", "HTTP://www.LostDutchmanSoftware.com");

            return new JavaScriptSerializer().Serialize(Word);
        }
        
        private string WordOfTheDay(string language)
        {
            DateTime date = DateTime.Today;
            string TodaysWord = "Error in script. Please contact us at www.LostDutchmanSoftware.com";
            long Day = date.Ticks / 864000000000; //There are 864000000000 ticks per day

            switch (language.ToLower())
            {
                case "japanese": TodaysWord = Japanese[((int)Day % Japanese.Count())]; break;
                //case "spanish": TodaysWord = Japanese[((int)Day % Spanish.Count())]; break;
                //case "french": TodaysWord = Japanese[((int)Day % French.Count())]; break;
                //case "italian": TodaysWord = Japanese[((int)Day % Italian.Count())]; break;
                //case "german": TodaysWord = Japanese[((int)Day % German.Count())]; break;
                default: TodaysWord = "Sorry, URL is invalid. Please contact us at www.LostDutchmanSoftware.com"; break;
            }
            return TodaysWord;
        }
    }
}