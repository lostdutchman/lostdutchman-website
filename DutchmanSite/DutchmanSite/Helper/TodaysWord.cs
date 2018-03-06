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
                "<phoneme alphabet='ipa' ph='kio:kaɕo'>Kyoukasho</phoneme>. <phoneme alphabet='ipa' ph='kio:kaɕo'>Kyoukasho</phoneme>means textbook",
                "<phoneme alphabet='ipa' ph='jɯ:bʲi'>Yubi</phoneme>. <phoneme alphabet='ipa' ph='jɯ:bʲi'>Yubi</phoneme>means finger",
                "<phoneme alphabet='ipa' ph='o:ka:ɕi̥'>Okashii</phoneme>. <phoneme alphabet='ipa' ph='o:ka:ɕi̥'>Okashii</phoneme>means weird",
                "<phoneme alphabet='ipa' ph='to:ɾʲi:kɯmi'>Torikumi</phoneme>. <phoneme alphabet='ipa' ph='to:ɾʲi:kɯmi'>Torikumi</phoneme>means Sumo bout",
                "<phoneme alphabet='ipa' ph='ama:i'>Amai</phoneme>. <phoneme alphabet='ipa' ph='ama:i'>Amai</phoneme>means sweet",
                "<phoneme alphabet='ipa' ph='ɲi:tɕi:yobi'>Nichiyobi</phoneme>. <phoneme alphabet='ipa' ph='ɲi:tɕi:yobi'>Nichiyobi</phoneme>means Sunday",
                "<prosody rate='x-slow'><phoneme alphabet='ipa' ph='aki'>Aki</phoneme></prosody>. <prosody rate='x-slow'><phoneme alphabet='ipa' ph='aki'>Aki</phoneme></prosody>means autumn",
                "<phoneme alphabet='ipa' ph='do:jobi'>Douyobi</phoneme>. <phoneme alphabet='ipa' ph='do:jobi'>Douyobi</phoneme>means Saturday",
                "<phoneme alphabet='ipa' ph='kjo:rjo:ku'>Kyouryouku</phoneme>. <phoneme alphabet='ipa' ph='kjo:rjo:ku'>Kyouryoku</phoneme>means powerful",
                "<phoneme alphabet='ipa' ph='ka:ɕi:ko:ɕi'>Kashikoshi</phoneme>. <phoneme alphabet='ipa' ph='ka:ɕi:ko:ɕi'>Kashikoshi</phoneme>means wise",
                "<phoneme alphabet='ipa' ph='to:ko:ro'>Tokoro</phoneme>. <phoneme alphabet='ipa' ph='to:ko:ro'>Tokoro</phoneme>means place",
                "<phoneme alphabet='ipa' ph='mo:kɯ:jobi'>Mokuyobi</phoneme>. <phoneme alphabet='ipa' ph='mo:kɯ:jobi'>Mokuyobi</phoneme>means Thursday",
                "<phoneme alphabet='ipa' ph='ɕo:setsu'>Shousetsu</phoneme>. <phoneme alphabet='ipa' ph='ɕo:setsu'>Shousetsu</phoneme>means story",
                "<phoneme alphabet='ipa' ph='kɯ:sɯr'>Kusuri</phoneme>. <phoneme alphabet='ipa' ph='kɯ:sɯr'>Kusuri</phoneme>means medicine",
                "<phoneme alphabet='ipa' ph='kɯ:saɪ'>Kusai</phoneme>. <phoneme alphabet='ipa' ph='kɯ:saɪ'>Kusai</phoneme>means stinky",
                "<phoneme alphabet='ipa' ph='sɯi:jobi'>Suiyobi</phoneme>. <phoneme alphabet='ipa' ph='sɯi:jobi'>Suiyobi</phoneme>means Wednesday",
                "<phoneme alphabet='ipa' ph='ke:satsukan'>Keisatsukan</phoneme>. <phoneme alphabet='ipa' ph='ke:satsukan'>Keisatsukan</phoneme>means police officer",
                "<phoneme alphabet='ipa' ph='ha:zɯ:ka:ɕi'>Hazukashii</phoneme>. <phoneme alphabet='ipa' ph='ha:zɯ:ka:ɕi'>Hazukashii</phoneme>means embarrassed",
                "<phoneme alphabet='ipa' ph='ka:jobi'>Kayobi</phoneme>. <phoneme alphabet='ipa' ph='ka:jobi'>Kayobi</phoneme>means Tuesday",
                "<phoneme alphabet='ipa' ph='kɯ:tɕi'>Kuchi</phoneme>. <phoneme alphabet='ipa' ph='kɯ:tɕi'>Kuchi</phoneme>means mouth",
                "<phoneme alphabet='ipa' ph='ɕi:go:to'>Shigoto</phoneme>. <phoneme alphabet='ipa' ph='ɕi:go:to'>Shigoto</phoneme>means job",
                "<phoneme alphabet='ipa' ph='gan:ko'>Ganko</phoneme>. <phoneme alphabet='ipa' ph='gan:ko'>Ganko</phoneme>means stubborn",
                "<phoneme alphabet='ipa' ph='sɯ:paɪ'>Supai</phoneme>. <phoneme alphabet='ipa' ph='sɯ:paɪ'>Supai/phoneme>means sour",
                "<phoneme alphabet='ipa' ph='o:so:ɪ'>Osoi</phoneme>. <phoneme alphabet='ipa' ph='o:so:i'>Osoɪ</phoneme>means slow",
                "<phoneme alphabet='ipa' ph='i:nu'>Inu</phoneme>. <phoneme alphabet='ipa' ph='i:nu'>Inu</phoneme>means dog",
                "<phoneme alphabet='ipa' ph='te:ni:su'>Tenisu</phoneme>. <phoneme alphabet='ipa' ph='te:ni:su'>Tenisu</phoneme>means tennis",
                "<phoneme alphabet='ipa' ph='mi:zu'>Mizu</phoneme>. <phoneme alphabet='ipa' ph='mi:zu'>Mizu</phoneme>means water",
                "<phoneme alphabet='ipa' ph='çon'>Hon</phoneme>. <phoneme alphabet='ipa' ph='çon'>Hon</phoneme>means book",
                "<phoneme alphabet='ipa' ph='gakɯse'>Gakusei</phoneme>. <phoneme alphabet='ipa' ph='gakɯse'>Gakusei</phoneme>means student",
                "<phoneme alphabet='ipa' ph='tori'>Tori</phoneme>. <phoneme alphabet='ipa' ph='tori'>Tori</phoneme>means bird",
                "<phoneme alphabet='ipa' ph='sakana'>Sakana</phoneme>. <phoneme alphabet='ipa' ph='sakana'>Sakana</phoneme>means fish",
                "<phoneme alphabet='ipa' ph='hito'>Hito</phoneme>. <phoneme alphabet='ipa' ph='hito'>Hito</phoneme>means person",
                "<phoneme alphabet='ipa' ph='tomoda.tɕi'>Tomodachi</phoneme>. <phoneme alphabet='ipa' ph='tomoda.tɕi'>Tomodachi</phoneme>means friend",
                "<phoneme alphabet='ipa' ph='ɡa̠k̚ko̞'>Gakkou</phoneme>. <phoneme alphabet='ipa' ph='ɡa̠k̚ko̞'>Gakkou</phoneme>means school",
                "<phoneme alphabet='ipa' ph='wakɯse'>Wakusei</phoneme>. <phoneme alphabet='ipa' ph='wakɯse'>Wakusei</phoneme>means planet",
                "<phoneme alphabet='ipa' ph='o̞t͡ɕa̠'>Ocha</phoneme>. <phoneme alphabet='ipa' ph='o̞t͡ɕa̠'>Ocha</phoneme>means tea",
                "<phoneme alphabet='ipa' ph='kodomo'>Kodomo</phoneme>. <phoneme alphabet='ipa' ph='kodomo'>Kodomo</phoneme>means child",
                "<phoneme alphabet='ipa' ph='d͡ʑikan'>Jikan</phoneme>. <phoneme alphabet='ipa' ph='d͡ʑikan'>Jikan</phoneme>means time",
                "<phoneme alphabet='ipa' ph='o̞ha̠jo̞goza:ɪmás'>Ohyaogozaimasu</phoneme>. <phoneme alphabet='ipa' ph='o̞ha̠jo̞goza:ɪmás'>Ohyaogozaimasu</phoneme>means good morning",
                "<phoneme alphabet='ipa' ph='getsujobi'>Getsuyobi</phoneme>. <phoneme alphabet='ipa' ph='getsujobi'>Getsuyobi</phoneme>means Monday",
                "<phoneme alphabet='ipa' ph='kino'>Kino</phoneme>. <phoneme alphabet='ipa' ph='kino'>Kino</phoneme>means yesterday",
                "<phoneme alphabet='ipa' ph='koɲ̟it͡ɕiwa'>Konnichiwa</phoneme>. <phoneme alphabet='ipa' ph='koɲ̟it͡ɕiwa'>Konnichiwa</phoneme>means hello",
                "<phoneme alphabet='ipa' ph='jo ɾu'>Yoru</phoneme>. <phoneme alphabet='ipa' ph='jo ɾu'>Yoru</phoneme>means night",
                "<phoneme alphabet='ipa' ph='aɕ ta'>Ashita</phoneme>. <phoneme alphabet='ipa' ph='aɕ ta'>Ashita</phoneme>means tomorrow",
                "<phoneme alphabet='ipa' ph='ko ko'>Koko</phoneme>. <phoneme alphabet='ipa' ph='ko ko'>Koko</phoneme>means here",
                "<phoneme alphabet='ipa' ph='mo mo'>Momo</phoneme>. <phoneme alphabet='ipa' ph='mo mo'>Momo</phoneme>means peach",
                "<phoneme alphabet='ipa' ph='kəˈwaɪ'>Kawaii</phoneme>. <phoneme alphabet='ipa' ph='kəˈwaɪ'>Kawaii</phoneme>means cute",
                "<phoneme alphabet='ipa' ph='isogaɕi'>Isogashii</phoneme>. <phoneme alphabet='ipa' ph='isogaɕi'>Isogashii</phoneme>means busy",
                "<phoneme alphabet='ipa' ph='ojasumi nasaɪ'>Oyasuminasai</phoneme>. <phoneme alphabet='ipa' ph='ojasumi nasaɪ'>Oyasuminasai</phoneme>means good night",
                "<phoneme alphabet='ipa' ph='niku'>Niku</phoneme>. <phoneme alphabet='ipa' ph='niku'>Niku</phoneme>means meat",
                "<phoneme alphabet='ipa' ph='kom.baɴ.w͍a'>Konbanwa</phoneme>. <phoneme alphabet='ipa' ph='kom.baɴ.w͍a'>Konbanwa</phoneme>means good evening",
                "<phoneme alphabet='ipa' ph='jɑ.sɯ.i'>Yasui</phoneme>. <phoneme alphabet='ipa' ph='jɑ.sɯ.i'>Yasui</phoneme>means vegetable",
                "<phoneme alphabet='ipa' ph='kudasaɪ'>Kudasai</phoneme>. <phoneme alphabet='ipa' ph='kudasaɪ'>Kudasai</phoneme>means please",
                "<phoneme alphabet='ipa' ph='ta̠bemo̞:no'>Tabemono</phoneme>. <phoneme alphabet='ipa' ph='ta̠bemo̞:no'>Tabemono</phoneme>means food",
                "<phoneme alphabet='ipa' ph='sɨᵝmʲima̠seɴ'>Sumimasen</phoneme>. <phoneme alphabet='ipa' ph='sɨᵝmʲima̠seɴ'>Sumimasen</phoneme>means excuse me",
                "<phoneme alphabet='ipa' ph='bu:do'>Budou</phoneme>. <phoneme alphabet='ipa' ph='bu:do'>Budou</phoneme>means grape",
                "<phoneme alphabet='ipa' ph='denwa'>Denwa</phoneme>. <phoneme alphabet='ipa' ph='denwa'>Denwa</phoneme>means telephone",
                "<phoneme alphabet='ipa' ph='iɕa'>Isha</phoneme>. <phoneme alphabet='ipa' ph='iɕa'>Isha</phoneme>means doctor",
                "<phoneme alphabet='ipa' ph='ɑɹiˈɡɑtoʊgoza:ɪmás'>Arigatougozaimasu</phoneme>. <phoneme alphabet='ipa' ph='ɑɹiˈɡɑtoʊgoza:ɪmás'>Arigatougozaimasu</phoneme>means thank you very much",
                "<phoneme alphabet='ipa' ph='ɕinbun'>Shinbun</phoneme>. <phoneme alphabet='ipa' ph='ɕinbun'>Shinbun</phoneme>means newspaper",
                "<phoneme alphabet='ipa' ph='denɕa'>Densha</phoneme>. <phoneme alphabet='ipa' ph='denɕa'>Densha</phoneme>means train",
                "<phoneme alphabet='ipa' ph='ko̞ːçi'>Kohi</phoneme>. <phoneme alphabet='ipa' ph='ko̞ːçi'>Kohi</phoneme>means coffee",
                "<phoneme alphabet='ipa' ph='haɪ'>Hai</phoneme>. <phoneme alphabet='ipa' ph='haɪ'>Hai</phoneme>means yes",
                "<phoneme alphabet='ipa' ph='dobutsu'>Doubutsu</phoneme>. <phoneme alphabet='ipa' ph='dobutsu'>Doubutsu</phoneme>means animal",
                "<phoneme alphabet='ipa' ph='a na ta'>Anata</phoneme>. <phoneme alphabet='ipa' ph='a na ta'>Anata</phoneme>means you",
                "<phoneme alphabet='ipa' ph='atsuꜜi'>Atsui</phoneme>. <phoneme alphabet='ipa' ph='atsuꜜi'>Atsui</phoneme>means hot",
                "<phoneme alphabet='ipa' ph='haru'>Haru</phoneme>. <phoneme alphabet='ipa' ph='haru'>Haru</phoneme>means spring",
                "<phoneme alphabet='ipa' ph='iie'>Iie</phoneme>. <phoneme alphabet='ipa' ph='iie'>Iie</phoneme>means no",
                "<phoneme alphabet='ipa' ph='san'>-San</phoneme>. <phoneme alphabet='ipa' ph='san'>-San</phoneme>means mister or missus at the end of someone's name",
                "<phoneme alphabet='ipa' ph='wa taɕi'>Watashi</phoneme>. <phoneme alphabet='ipa' ph='wa taɕi'>Watashi</phoneme>means I",
                "<phoneme alphabet='ipa' ph='natsu'>Natsu</phoneme>. <phoneme alphabet='ipa' ph='natsu'>Natsu</phoneme>means summer",
                "<phoneme alphabet='ipa' ph='ame'>Ame</phoneme>. <phoneme alphabet='ipa' ph='ame'>Ame</phoneme>means rain",
                "<phoneme alphabet='ipa' ph='tama go'>Tamago</phoneme>. <phoneme alphabet='ipa' ph='tama go'>Tamago</phoneme>means egg",
                "<phoneme alphabet='ipa' ph='juki'>Yuki</phoneme>. <phoneme alphabet='ipa' ph='juki'>Yuki</phoneme>mens snow",
                "<phoneme alphabet='ipa' ph='umi'>Umi</phoneme>. <phoneme alphabet='ipa' ph='umi'>Umi</phoneme>means ocean",
                "<phoneme alphabet='ipa' ph='fuju'>Fuyu</phoneme>. <phoneme alphabet='ipa' ph='fuju'>Fuyu</phoneme>means winter",
                "<phoneme alphabet='ipa' ph='itɕigo'>Ichigo</phoneme>. <phoneme alphabet='ipa' ph='itɕigo'>Ichigo</phoneme>means strawberry",
                "<phoneme alphabet='ipa' ph='mikan'>Mikan</phoneme>. <phoneme alphabet='ipa' ph='mikan'>Mikan</phoneme>means tangerine",
                "<phoneme alphabet='ipa' ph='neko'>Neko</phoneme>. <phoneme alphabet='ipa' ph='neko'>Neko</phoneme>means cat",
                "<phoneme alphabet='ipa' ph='e:ga'>Eiga</phoneme>. <phoneme alphabet='ipa' ph='e:ga'>Eiga</phoneme>means movie",
                "<phoneme alphabet='ipa' ph='on gaku'>Ongaku</phoneme>. <phoneme alphabet='ipa' ph='on gaku'>Ongaku</phoneme>means music",
                "<phoneme alphabet='ipa' ph='a sagohan'>Asagohan</phoneme>. <phoneme alphabet='ipa' ph='a sagohan'>Asagohan</phoneme>means breakfast",
                "<phoneme alphabet='ipa' ph='d͡ʑitenɕa̠'>Jitensha</phoneme>. <phoneme alphabet='ipa' ph='d͡ʑitenɕa̠'>Jitensha</phoneme>means bicycle",
                "<phoneme alphabet='ipa' ph='usagi'>Usagi</phoneme>. <phoneme alphabet='ipa' ph='usagi'>Usagi</phoneme>means rabbit",
                "<phoneme alphabet='ipa' ph='ringo'>Ringo</phoneme>. <phoneme alphabet='ipa' ph='ringo'>Ringo</phoneme>means apple",
                "<phoneme alphabet='ipa' ph='sora'>Sora</phoneme>. <phoneme alphabet='ipa' ph='sora'>Sora</phoneme>means sky",
                "<phoneme alphabet='ipa' ph='taɪjo'>Taiyou</phoneme>. <phoneme alphabet='ipa' ph='taɪjo'>Taiyou</phoneme>means the sun",
                "<phoneme alphabet='ipa' ph='hana'>Hana</phoneme>. <phoneme alphabet='ipa' ph='hana'>Hana</phoneme>means flower",
                "<phoneme alphabet='ipa' ph='ɕima'>Shima</phoneme>. <phoneme alphabet='ipa' ph='ɕima'>Shima</phoneme>means island",
                "<phoneme alphabet='ipa' ph='isu'>Issu</phoneme>. <phoneme alphabet='ipa' ph='isu'>Issu</phoneme>means chair",
                "<phoneme alphabet='ipa' ph='haɕi'>Hashi</phoneme>. <phoneme alphabet='ipa' ph='haɕi'>Hashi</phoneme>means chopsticks",
                "<phoneme alphabet='ipa' ph='samui'>Samui</phoneme>. <phoneme alphabet='ipa' ph='samui'>Samui</phoneme>means cold",
                "<phoneme alphabet='ipa' ph='niwa'>Niwa</phoneme>. <phoneme alphabet='ipa' ph='niwa'>Niwa</phoneme>means garden",
                "<phoneme alphabet='ipa' ph='ku:ko'>Kuukou</phoneme>. <phoneme alphabet='ipa' ph='ku:ko'>Kuukou</phoneme>means airport",
                "<phoneme alphabet='ipa' ph='&#39;matsu ri'>Matsuri</phoneme>. <phoneme alphabet='ipa' ph='&#39;matsu ri'>Matsuri</phoneme>means festival",
                "<phoneme alphabet='ipa' ph='o kah san'>Okaasan</phoneme>. <phoneme alphabet='ipa' ph='o kah san'>Okaasan</phoneme>means mother",
                "<phoneme alphabet='ipa' ph='mu su ko'>Musuko</phoneme>. <phoneme alphabet='ipa' ph='mu su ko'>Musuko</phoneme>means son",
                "<phoneme alphabet='ipa' ph='ah ka'>Aka</phoneme>. <phoneme alphabet='ipa' ph='ah ka'>Aka</phoneme>means red",
                "<phoneme alphabet='ipa' ph='o to san'>Otousan</phoneme>. <phoneme alphabet='ipa' ph='o to san'>Otousan</phoneme>means father",
                "<phoneme alphabet='ipa' ph='ku ro'>Kuro</phoneme>. <phoneme alphabet='ipa' ph='ku ro'>Kuro</phoneme>means black"
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