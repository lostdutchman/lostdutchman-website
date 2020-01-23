using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace DutchmanSite.Helper
{
    public class AlexaFlashBrief
    {
        #region Breif Strings
        #region SwordFacts
        private List<string> SwordFacts = new List<string> {
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Gramr is the sword Sigurd used to kill the dragon Fafnir in the Icelandic Volsunga Saga",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The Sword of Mars belonged to Attila the Hun, Roman historian Jordanes describes how Attila obtained the sword as follows. When a certain shepherd beheld one heifer of his flock limping and could find no cause for this wound, he anxiously followed the trail of blood and at length came to a sword it had unwittingly trampled while nibbling the grass. He dug it up and took it straight to Attila. He rejoiced at this gift and, being ambitious, thought he had been appointed ruler of the whole world, and that through the sword of Mars supremacy in all wars was assured to him.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Colada was a sword won in combat by El Cid Campeador when he defeated Count Barcelona. Colada clearly means a sword made from acero colado. cast steel",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Tizona   was a sword won in combat by El Cid Campeador when he defeated Count Barcelona. Acid etched inscriptions in the fullers on either side of the blade read.   I am the Tizona, who was made in the year 1040  Hail Mary, full of grace; the Lord be with me",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Durendal is the sword of the legendary french paladin Roland. According to the song of Roland the sword was brought by an angel to Charlemagne who was at the vale of Moriane, and Charles then gave it to Roland. The sword is said to contain within its golden hilt a tooth of Saint Peter, blood of Basil of Caesarea, hair of Saint Denis, and a piece of the raiment of Mary, mother of Jesus, and to be the sharpest sword in all existence.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Excalibur is the sword of King Arthur.  In Chrétien de Troyes Perceval, Arthurs knight Gawain carries the sword Escalibor and it is stated. for at his belt hung Escalibor, the finest sword that there was, which sliced through iron as through wood",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Joyeuse was Charlemagnes sword, said to have been forged to contain the Lance of Longinus within it pommel. Featured in the Song of Roland as follows. Charlemagne was wearing his fine white coat of mail and his helmet with gold-studded stones. by his side hung Joyeuse, and never was there a sword to match it. its colour changed thirty times a day. ",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Kuu saw nah ghee is one of the three Imperial Regalia of Japan. It is believed to have been given by the goddess Ah ma teh ra sue   to Ya ma toe Ta keh rue, the son of the Emperor Keh ee koh. It was during this time that the   Kuu saw nah ghee  gained its present name   Kuu saw nah ghee no sue rue ghee or Grass Cutting Sword. According to one story, the prince was on a hunting trip when a rival set fire to the dry grass around him. Using the sword, Ya ma toe cut the burning grass down, and sent the flames in the direction of his rival.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The Sword of Laban wielded by Nephi. The Book of Morman describes it as follows. Nevertheless I went forth, and as I came near unto the house of Laban I beheld a man, and he had fallen to the earth before me, for he was drunken with wine.  And when I came to him I found that it was Laban.  And I beheld his sword, and I drew it forth from the sheath thereof; and the hilt thereof was of pure gold, and the workmanship thereof was exceedingly fine, and I saw that the blade thereof was of the most precious steel.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Legbiter was the sword of viking king Magnus Barelegs. Legbiters hilt was ivory and the hand grip wound with gold thread",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Skofnung was the sword of Danish king Hrólf Krak. Said to be the best of all swords that have been carried in northern lands, it was renowned for supernatural sharpness and hardness, as well as for being imbued with the spirits of the kings 12 faithful berserker bodyguards.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Ḏū-l-Fiqār is the name of the sword of Ali ibn Abi Talib which is said to have been given to him by Muhammad. Muhammad gave this sword to his son-in-law Ali in the Battle of Uhud. According to Islamic tradition, the sword was brought by Gabrial Lord of the Angels as an order from Allah. It is frequently depicted as a scissor-like double bladed sword",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Sword of Saint Peter is allegedly the sword with which the Apostle Peter cut off the right ear of the high priests servant at the time of Jesus&apos; arrest in Gethsemane.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Nah nah tsu say ya no Ta chi, or Seven-Branched Sword. An inscription on the blade reveals the Seven-Branched Sword was given by the king of Baekje an ancient kingdom in the south western part of the Korean Peninsula to the ruler of Japan",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Sword in the Stone of San Galgano, According to legend San Galgano was walking on Montesiepi when he saw a voice spoke to him, commanding him to renounce all his worldly desires. San Galgano replied that this was as easy as splitting stones with a sword, and with that he drew his sword and thrust it into a stone.  To his great amazement, the weapon went through the stone like a hot knife through butter, and has been stuck in the stone ever since.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Goujian was the sword of the King of Yue. Discovered in a burial tomb in China in 1965 the blade was untarnished and still shard despite being in a flooded tomb for nearly 2000 years.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Curtana, also known as the Sword of Mercy, is a ceremonial sword used at the coronation of British kings and queens. One of the Crown Jewels of the United Kingdom, its end is blunt and squared to symbolize mercy. ",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Lobera was the sword of the King of León who writes that King Ferdinand the third, lying on his deathbed, addressed him in these words. I can bequeath no heritage to you, but I bestow upon you my sword Lobera, that is of passing worth, and wherewith God has wrought much good to me.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Szczerbiec is said to be the sword of King Boleslaw the Brave who chipped it by hitting it against the Golden Gate in Kiev",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The Wallace Sword is an antique two-handed sword purported to have belonged to William Wallace, a Scottish knight who led a resistance to the English occupation of Scotland during the Wars of Scottish Independence. It is said to have been used by William Wallace at the Battle of Stirling in 1297 and the Battle of Falkirk.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The Sword of Saints Cosmas and Damian, is a ceremonial weapon in Essen Abbey. The silver locket mounts show images of Saints Cosmas and Damian, along with the Latin inscription. the sword, with which our patrons were beheaded.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The Sword of Gjergj Kastrioti Skanderbeg of Albania. According to legends his sword was so heavy that only his arm could wield it. Also it was said to be so sharp that it could slice a man vertically from head to waist with little effort and cut a huge boulder in half with a single blow.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Shamshir-e-Zomorrodnegar, from the Persian legend Amir Arsalan. Tales claim that a hideous horned demon called Fulad-zereh was invulnerable to all weapons except this sword. It originally belonged to King Solomon, and was carefully guarded by Fulad-zereh, not only because of its value and the fact that it could harm him, but also because wearing it was a charm against magic. ",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Muramasa Sengo was a legendary swordsmith who lived during the Muromachi period in Japan, and was said to have been completely mad and prone to bouts of violence. It was believed that these destructive qualities were passed by the master swordsmith into the blades he forged. The blades would then possess their wielders, turning them into insane and deadly warriors. During the reign of Togugawa Ieyasu, the first shogun of the Edo period, Muramasas blades fell out of favour. The shoguns father and grandfather were both murdered by their retainers who were wielding Muramasa blades and so it came to be thought that Muramasa’s blades carried a curse again members of the Tokugawa family. Consequently, the shogun banned ownership of the Muramasa. ",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Ulfberht swords were Viking made of metal so pure, and crafted with crucible steel, which has a carbon content three times higher than that of other metals of the time.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The harpē sword used by Cronus, son of Uranus, to castrate his father. It was also used by Perseus to decapitate Medusa.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Joan of Arcs Sword. Saint Joan of Arc had a vision from Michael the  Archangel, which showed her a holy sword behind the altar  of the Church of Saint Catherine of Fierbois. Upon finding it, the rust  was easily wiped off the sword and five crosses were revealed.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Fragarach, a Celtic sword said to be forged by the gods themselves. Carried by Manannán mac Lir, the guardian of the Otherworld and pilot of the boat ferrying souls to the afterlife. The sword was reputed to cut through any armor, and give the user control of the winds.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Sword of Eden, A flaming sword that guarded the entrance to the garden of eden after Eve and Adam were cast out.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Gan Jiang. Crafted by the smiths  Gan Jiang and Mo Ye the blast  furnace   could not melt the metal to make these swords. To add more chi the couple cut off their hair and nails to add to the fire, then had 300 children blow into the bellows. After three years two impressive swords were completed. The smith Gan Jiang kept the sword named after himself",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Mo Ye.   Crafted by the smiths  Gan Jiang and Mo Ye the blast  furnace   could not melt the metal to make these swords. To add more chi the couple cut off their hair and nails to add to the fire, then had 300 children blow into the bellows. After three years two impressive swords were completed. The sword Mo Ye was sent to the king that commissioned the swords, furious to only get one of the two commissioned swords the king has Gan Jiang killed.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Caladbolg, A legendary two handed sword wielded by  Fergus mac Róich. Said to be powerful enough to cut the tops from hills.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Thuận Thiên, the sword of Vietnamese king Le Loi. Legend is that the sword increaded the kings size and gave him the strength of a thousand men.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is Sword of Damocles. According to the story, Damocles was pandering to Dionysius, his king, and exclaimed to him that Dionysius was truly fortunate as a great man of power and authority, surrounded by magnificence. In response, Dionysius offered to switch places with Damocles for one day so that Damocles could taste that very fortune firsthand. Damocles quickly and eagerly accepted the king's proposal. Damocles sat down in the king's throne surrounded by every luxury, but Dionysius arranged that a huge sword should hang above the throne, held at the pommel only by a single hair of a horse's tail. Damocles finally begged the king that he be allowed to depart because he no longer wanted to be so fortunate, realizing that with great fortune and power comes also great danger. King Dionysius effectively conveyed the sense of constant fear in which a person with great power may live.",
            " with our Dungeon world Expansion. Word Of Stromgard. Visit Double You Why Are Dee dot lost dutchman software dot com for more information. Now Todays Legendary Sword is The Koo saw nah ghee. This swords was found in the body of an eight-headed serpent killed by the god of storms. The    Koo saw nah ghee is part of the Imperial Regalia and said to be housed in Ah tsu ta shrine."
    };
        #endregion
        
        #region Expand1
        private List<string> French = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #region Expand3
        private List<string> Italian = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #region Expand2
        private List<string> German = new List<string>
        {
            //replace with list for language
        };
        #endregion
        #endregion

        public string jsonBuilder(string FactList)
        {
            Dictionary<string, string> Word = new Dictionary<string, string>();
            Word.Add("uid", Guid.NewGuid().ToString());
            Word.Add("updateDate", DateTime.Today.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Word.Add("titleText", FactListTitle(FactList));
            Word.Add("mainText", FactOfTheDay(FactList));
            Word.Add("redirectionUrl", "HTTP://www.LostDutchmanSoftware.com");

            return new JavaScriptSerializer().Serialize(Word);
        }

        private string FactListTitle(string FactList)
        {
            string Title = "Help I'm lost";

            switch (FactList.ToLower())
            {
                case "swordfacts": Title = "Make your own legend"; break;
                //case "swordfacts": Title = "Todays Legendary Sword Fact"; break;
                //case "swordfacts": Title = "Todays Legendary Sword Fact"; break;
                //case "swordfacts": Title = "Todays Legendary Sword Fact"; break;
                //case "swordfacts": Title = "Todays Legendary Sword Fact"; break;
                default: Title = "I think i've found the mine"; break;
            }
            return Title;
        }

        private string FactOfTheDay(string FactList)
        {
            DateTime date = DateTime.Today;
            string Fact = "Error in script. Please contact us at www.LostDutchmanSoftware.com";
            long Day = date.Ticks / 864000000000; //There are 864000000000 ticks per day

            switch (FactList.ToLower())
            {
                case "swordfacts": Fact = SwordFacts[((int)Day % SwordFacts.Count())]; break;
                //case "swordfacts": Fact = SwordFacts[((int)Day % SwordFacts.Count())]; break;
                //case "swordfacts": Fact = SwordFacts[((int)Day % SwordFacts.Count())]; break;
                //case "swordfacts": Fact = SwordFacts[((int)Day % SwordFacts.Count())]; break;
                //case "swordfacts": Fact = SwordFacts[((int)Day % SwordFacts.Count())]; break;
                default: Fact = "Sorry, URL is invalid. Please contact us at www.LostDutchmanSoftware.com"; break;
            }
            return Fact;
        }
    }
}