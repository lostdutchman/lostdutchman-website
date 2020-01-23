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
                "<phoneme alphabet='ipa' ph='kio:kaɕo'>Kyoukasho</phoneme>. <phoneme alphabet='ipa' ph='kio:kaɕo'>Kyoukasho</phoneme> means textbook",
                "<phoneme alphabet='ipa' ph='jɯ:bʲi'>Yubi</phoneme>. <phoneme alphabet='ipa' ph='jɯ:bʲi'>Yubi</phoneme> means finger",
                "<phoneme alphabet='ipa' ph='o:ka:ɕi̥'>Okashii</phoneme>. <phoneme alphabet='ipa' ph='o:ka:ɕi̥'>Okashii</phoneme> means weird",
                "<phoneme alphabet='ipa' ph='to:ɾʲi:kɯmi'>Torikumi</phoneme>. <phoneme alphabet='ipa' ph='to:ɾʲi:kɯmi'>Torikumi</phoneme> means Sumo bout",
                "<phoneme alphabet='ipa' ph='ama:i'>Amai</phoneme>. <phoneme alphabet='ipa' ph='ama:i'>Amai</phoneme> means sweet",
                "<phoneme alphabet='ipa' ph='ɲi:tɕi:yobi'>Nichiyobi</phoneme>. <phoneme alphabet='ipa' ph='ɲi:tɕi:yobi'>Nichiyobi</phoneme> means Sunday",
                "<prosody rate='x-slow'><phoneme alphabet='ipa' ph='aki'>Aki</phoneme></prosody>. <prosody rate='x-slow'><phoneme alphabet='ipa' ph='aki'>Aki</phoneme></prosody>means autumn",
                "<phoneme alphabet='ipa' ph='do:jobi'>Douyobi</phoneme>. <phoneme alphabet='ipa' ph='do:jobi'>Douyobi</phoneme> means Saturday",
                "<phoneme alphabet='ipa' ph='kjo:rjo:ku'>Kyouryouku</phoneme>. <phoneme alphabet='ipa' ph='kjo:rjo:ku'>Kyouryoku</phoneme> means powerful",
                "<phoneme alphabet='ipa' ph='ka:ɕi:ko:ɕi'>Kashikoshi</phoneme>. <phoneme alphabet='ipa' ph='ka:ɕi:ko:ɕi'>Kashikoshi</phoneme> means wise",
                "<phoneme alphabet='ipa' ph='to:ko:ro'>Tokoro</phoneme>. <phoneme alphabet='ipa' ph='to:ko:ro'>Tokoro</phoneme> means place",
                "<phoneme alphabet='ipa' ph='mo:kɯ:jobi'>Mokuyobi</phoneme>. <phoneme alphabet='ipa' ph='mo:kɯ:jobi'>Mokuyobi</phoneme> means Thursday",
                "<phoneme alphabet='ipa' ph='ɕo:setsu'>Shousetsu</phoneme>. <phoneme alphabet='ipa' ph='ɕo:setsu'>Shousetsu</phoneme> means story",
                "<phoneme alphabet='ipa' ph='kɯ:sɯr'>Kusuri</phoneme>. <phoneme alphabet='ipa' ph='kɯ:sɯr'>Kusuri</phoneme> means medicine",
                "<phoneme alphabet='ipa' ph='kɯ:saɪ'>Kusai</phoneme>. <phoneme alphabet='ipa' ph='kɯ:saɪ'>Kusai</phoneme> means stinky",
                "<phoneme alphabet='ipa' ph='sɯi:jobi'>Suiyobi</phoneme>. <phoneme alphabet='ipa' ph='sɯi:jobi'>Suiyobi</phoneme> means Wednesday",
                "<phoneme alphabet='ipa' ph='ke:satsukan'>Keisatsukan</phoneme>. <phoneme alphabet='ipa' ph='ke:satsukan'>Keisatsukan</phoneme> means police officer",
                "<phoneme alphabet='ipa' ph='ha:zɯ:ka:ɕi'>Hazukashii</phoneme>. <phoneme alphabet='ipa' ph='ha:zɯ:ka:ɕi'>Hazukashii</phoneme> means embarrassed",
                "<phoneme alphabet='ipa' ph='ka:jobi'>Kayobi</phoneme>. <phoneme alphabet='ipa' ph='ka:jobi'>Kayobi</phoneme> means Tuesday",
                "<phoneme alphabet='ipa' ph='kɯ:tɕi'>Kuchi</phoneme>. <phoneme alphabet='ipa' ph='kɯ:tɕi'>Kuchi</phoneme> means mouth",
                "<phoneme alphabet='ipa' ph='ɕi:go:to'>Shigoto</phoneme>. <phoneme alphabet='ipa' ph='ɕi:go:to'>Shigoto</phoneme> means job",
                "<phoneme alphabet='ipa' ph='gan:ko'>Ganko</phoneme>. <phoneme alphabet='ipa' ph='gan:ko'>Ganko</phoneme> means stubborn",
                "<phoneme alphabet='ipa' ph='sɯ:paɪ'>Supai</phoneme>. <phoneme alphabet='ipa' ph='sɯ:paɪ'>Supai/phoneme>means sour",
                "<phoneme alphabet='ipa' ph='o:so:ɪ'>Osoi</phoneme>. <phoneme alphabet='ipa' ph='o:so:i'>Osoɪ</phoneme> means slow",
                "<phoneme alphabet='ipa' ph='i:nu'>Inu</phoneme>. <phoneme alphabet='ipa' ph='i:nu'>Inu</phoneme> means dog",
                "<phoneme alphabet='ipa' ph='te:ni:su'>Tenisu</phoneme>. <phoneme alphabet='ipa' ph='te:ni:su'>Tenisu</phoneme> means tennis",
                "<phoneme alphabet='ipa' ph='mi:zu'>Mizu</phoneme>. <phoneme alphabet='ipa' ph='mi:zu'>Mizu</phoneme> means water",
                "<phoneme alphabet='ipa' ph='çon'>Hon</phoneme>. <phoneme alphabet='ipa' ph='çon'>Hon</phoneme> means book",
                "<phoneme alphabet='ipa' ph='gakɯse'>Gakusei</phoneme>. <phoneme alphabet='ipa' ph='gakɯse'>Gakusei</phoneme> means student",
                "<phoneme alphabet='ipa' ph='tori'>Tori</phoneme>. <phoneme alphabet='ipa' ph='tori'>Tori</phoneme> means bird",
                "<phoneme alphabet='ipa' ph='sakana'>Sakana</phoneme>. <phoneme alphabet='ipa' ph='sakana'>Sakana</phoneme> means fish",
                "<phoneme alphabet='ipa' ph='hito'>Hito</phoneme>. <phoneme alphabet='ipa' ph='hito'>Hito</phoneme> means person",
                "<phoneme alphabet='ipa' ph='tomoda.tɕi'>Tomodachi</phoneme>. <phoneme alphabet='ipa' ph='tomoda.tɕi'>Tomodachi</phoneme> means friend",
                "<phoneme alphabet='ipa' ph='ɡa̠k̚ko̞'>Gakkou</phoneme>. <phoneme alphabet='ipa' ph='ɡa̠k̚ko̞'>Gakkou</phoneme> means school",
                "<phoneme alphabet='ipa' ph='wakɯse'>Wakusei</phoneme>. <phoneme alphabet='ipa' ph='wakɯse'>Wakusei</phoneme> means planet",
                "<phoneme alphabet='ipa' ph='o̞t͡ɕa̠'>Ocha</phoneme>. <phoneme alphabet='ipa' ph='o̞t͡ɕa̠'>Ocha</phoneme> means tea",
                "<phoneme alphabet='ipa' ph='kodomo'>Kodomo</phoneme>. <phoneme alphabet='ipa' ph='kodomo'>Kodomo</phoneme> means child",
                "<phoneme alphabet='ipa' ph='d͡ʑikan'>Jikan</phoneme>. <phoneme alphabet='ipa' ph='d͡ʑikan'>Jikan</phoneme> means time",
                "<phoneme alphabet='ipa' ph='o̞ha̠jo̞goza:ɪmás'>Ohyaogozaimasu</phoneme>. <phoneme alphabet='ipa' ph='o̞ha̠jo̞goza:ɪmás'>Ohyaogozaimasu</phoneme> means good morning",
                "<phoneme alphabet='ipa' ph='getsujobi'>Getsuyobi</phoneme>. <phoneme alphabet='ipa' ph='getsujobi'>Getsuyobi</phoneme> means Monday",
                "<phoneme alphabet='ipa' ph='kino'>Kino</phoneme>. <phoneme alphabet='ipa' ph='kino'>Kino</phoneme> means yesterday",
                "<phoneme alphabet='ipa' ph='koɲ̟it͡ɕiwa'>Konnichiwa</phoneme>. <phoneme alphabet='ipa' ph='koɲ̟it͡ɕiwa'>Konnichiwa</phoneme> means hello",
                "<phoneme alphabet='ipa' ph='jo ɾu'>Yoru</phoneme>. <phoneme alphabet='ipa' ph='jo ɾu'>Yoru</phoneme> means night",
                "<phoneme alphabet='ipa' ph='aɕ ta'>Ashita</phoneme>. <phoneme alphabet='ipa' ph='aɕ ta'>Ashita</phoneme> means tomorrow",
                "<phoneme alphabet='ipa' ph='ko ko'>Koko</phoneme>. <phoneme alphabet='ipa' ph='ko ko'>Koko</phoneme> means here",
                "<phoneme alphabet='ipa' ph='mo mo'>Momo</phoneme>. <phoneme alphabet='ipa' ph='mo mo'>Momo</phoneme> means peach",
                "<phoneme alphabet='ipa' ph='kəˈwaɪ'>Kawaii</phoneme>. <phoneme alphabet='ipa' ph='kəˈwaɪ'>Kawaii</phoneme> means cute",
                "<phoneme alphabet='ipa' ph='isogaɕi'>Isogashii</phoneme>. <phoneme alphabet='ipa' ph='isogaɕi'>Isogashii</phoneme> means busy",
                "<phoneme alphabet='ipa' ph='ojasumi nasaɪ'>Oyasuminasai</phoneme>. <phoneme alphabet='ipa' ph='ojasumi nasaɪ'>Oyasuminasai</phoneme> means good night",
                "<phoneme alphabet='ipa' ph='niku'>Niku</phoneme>. <phoneme alphabet='ipa' ph='niku'>Niku</phoneme> means meat",
                "<phoneme alphabet='ipa' ph='kom.baɴ.w͍a'>Konbanwa</phoneme>. <phoneme alphabet='ipa' ph='kom.baɴ.w͍a'>Konbanwa</phoneme> means good evening",
                "<phoneme alphabet='ipa' ph='jɑ.sɯ.i'>Yasui</phoneme>. <phoneme alphabet='ipa' ph='jɑ.sɯ.i'>Yasui</phoneme> means vegetable",
                "<phoneme alphabet='ipa' ph='kudasaɪ'>Kudasai</phoneme>. <phoneme alphabet='ipa' ph='kudasaɪ'>Kudasai</phoneme> means please",
                "<phoneme alphabet='ipa' ph='ta̠bemo̞:no'>Tabemono</phoneme>. <phoneme alphabet='ipa' ph='ta̠bemo̞:no'>Tabemono</phoneme> means food",
                "<phoneme alphabet='ipa' ph='sɨᵝmʲima̠seɴ'>Sumimasen</phoneme>. <phoneme alphabet='ipa' ph='sɨᵝmʲima̠seɴ'>Sumimasen</phoneme> means excuse me",
                "<phoneme alphabet='ipa' ph='bu:do'>Budou</phoneme>. <phoneme alphabet='ipa' ph='bu:do'>Budou</phoneme> means grape",
                "<phoneme alphabet='ipa' ph='denwa'>Denwa</phoneme>. <phoneme alphabet='ipa' ph='denwa'>Denwa</phoneme> means telephone",
                "<phoneme alphabet='ipa' ph='iɕa'>Isha</phoneme>. <phoneme alphabet='ipa' ph='iɕa'>Isha</phoneme> means doctor",
                "<phoneme alphabet='ipa' ph='ɑɹiˈɡɑtoʊgoza:ɪmás'>Arigatougozaimasu</phoneme>. <phoneme alphabet='ipa' ph='ɑɹiˈɡɑtoʊgoza:ɪmás'>Arigatougozaimasu</phoneme> means thank you very much",
                "<phoneme alphabet='ipa' ph='ɕinbun'>Shinbun</phoneme>. <phoneme alphabet='ipa' ph='ɕinbun'>Shinbun</phoneme> means newspaper",
                "<phoneme alphabet='ipa' ph='denɕa'>Densha</phoneme>. <phoneme alphabet='ipa' ph='denɕa'>Densha</phoneme> means train",
                "<phoneme alphabet='ipa' ph='ko̞ːçi'>Kohi</phoneme>. <phoneme alphabet='ipa' ph='ko̞ːçi'>Kohi</phoneme> means coffee",
                "<phoneme alphabet='ipa' ph='haɪ'>Hai</phoneme>. <phoneme alphabet='ipa' ph='haɪ'>Hai</phoneme> means yes",
                "<phoneme alphabet='ipa' ph='dobutsu'>Doubutsu</phoneme>. <phoneme alphabet='ipa' ph='dobutsu'>Doubutsu</phoneme> means animal",
                "<phoneme alphabet='ipa' ph='a na ta'>Anata</phoneme>. <phoneme alphabet='ipa' ph='a na ta'>Anata</phoneme> means you",
                "<phoneme alphabet='ipa' ph='atsuꜜi'>Atsui</phoneme>. <phoneme alphabet='ipa' ph='atsuꜜi'>Atsui</phoneme> means hot",
                "<phoneme alphabet='ipa' ph='haru'>Haru</phoneme>. <phoneme alphabet='ipa' ph='haru'>Haru</phoneme> means spring",
                "<phoneme alphabet='ipa' ph='iie'>Iie</phoneme>. <phoneme alphabet='ipa' ph='iie'>Iie</phoneme> means no",
                "<phoneme alphabet='ipa' ph='san'>-San</phoneme>. <phoneme alphabet='ipa' ph='san'>-San</phoneme> means mister or missus at the end of someone's name",
                "<phoneme alphabet='ipa' ph='wa taɕi'>Watashi</phoneme>. <phoneme alphabet='ipa' ph='wa taɕi'>Watashi</phoneme> means I",
                "<phoneme alphabet='ipa' ph='natsu'>Natsu</phoneme>. <phoneme alphabet='ipa' ph='natsu'>Natsu</phoneme> means summer",
                "<phoneme alphabet='ipa' ph='ame'>Ame</phoneme>. <phoneme alphabet='ipa' ph='ame'>Ame</phoneme> means rain",
                "<phoneme alphabet='ipa' ph='tama go'>Tamago</phoneme>. <phoneme alphabet='ipa' ph='tama go'>Tamago</phoneme> means egg",
                "<phoneme alphabet='ipa' ph='juki'>Yuki</phoneme>. <phoneme alphabet='ipa' ph='juki'>Yuki</phoneme>mens snow",
                "<phoneme alphabet='ipa' ph='umi'>Umi</phoneme>. <phoneme alphabet='ipa' ph='umi'>Umi</phoneme> means ocean",
                "<phoneme alphabet='ipa' ph='fuju'>Fuyu</phoneme>. <phoneme alphabet='ipa' ph='fuju'>Fuyu</phoneme> means winter",
                "<phoneme alphabet='ipa' ph='itɕigo'>Ichigo</phoneme>. <phoneme alphabet='ipa' ph='itɕigo'>Ichigo</phoneme> means strawberry",
                "<phoneme alphabet='ipa' ph='mikan'>Mikan</phoneme>. <phoneme alphabet='ipa' ph='mikan'>Mikan</phoneme> means tangerine",
                "<phoneme alphabet='ipa' ph='neko'>Neko</phoneme>. <phoneme alphabet='ipa' ph='neko'>Neko</phoneme> means cat",
                "<phoneme alphabet='ipa' ph='e:ga'>Eiga</phoneme>. <phoneme alphabet='ipa' ph='e:ga'>Eiga</phoneme> means movie",
                "<phoneme alphabet='ipa' ph='on gaku'>Ongaku</phoneme>. <phoneme alphabet='ipa' ph='on gaku'>Ongaku</phoneme> means music",
                "<phoneme alphabet='ipa' ph='a sagohan'>Asagohan</phoneme>. <phoneme alphabet='ipa' ph='a sagohan'>Asagohan</phoneme> means breakfast",
                "<phoneme alphabet='ipa' ph='d͡ʑitenɕa̠'>Jitensha</phoneme>. <phoneme alphabet='ipa' ph='d͡ʑitenɕa̠'>Jitensha</phoneme> means bicycle",
                "<phoneme alphabet='ipa' ph='usagi'>Usagi</phoneme>. <phoneme alphabet='ipa' ph='usagi'>Usagi</phoneme> means rabbit",
                "<phoneme alphabet='ipa' ph='ringo'>Ringo</phoneme>. <phoneme alphabet='ipa' ph='ringo'>Ringo</phoneme> means apple",
                "<phoneme alphabet='ipa' ph='sora'>Sora</phoneme>. <phoneme alphabet='ipa' ph='sora'>Sora</phoneme> means sky",
                "<phoneme alphabet='ipa' ph='taɪjo'>Taiyou</phoneme>. <phoneme alphabet='ipa' ph='taɪjo'>Taiyou</phoneme> means the sun",
                "<phoneme alphabet='ipa' ph='hana'>Hana</phoneme>. <phoneme alphabet='ipa' ph='hana'>Hana</phoneme> means flower",
                "<phoneme alphabet='ipa' ph='ɕima'>Shima</phoneme>. <phoneme alphabet='ipa' ph='ɕima'>Shima</phoneme> means island",
                "<phoneme alphabet='ipa' ph='isu'>Issu</phoneme>. <phoneme alphabet='ipa' ph='isu'>Issu</phoneme> means chair",
                "<phoneme alphabet='ipa' ph='haɕi'>Hashi</phoneme>. <phoneme alphabet='ipa' ph='haɕi'>Hashi</phoneme> means chopsticks",
                "<phoneme alphabet='ipa' ph='samui'>Samui</phoneme>. <phoneme alphabet='ipa' ph='samui'>Samui</phoneme> means cold",
                "<phoneme alphabet='ipa' ph='niwa'>Niwa</phoneme>. <phoneme alphabet='ipa' ph='niwa'>Niwa</phoneme> means garden",
                "<phoneme alphabet='ipa' ph='ku:ko'>Kuukou</phoneme>. <phoneme alphabet='ipa' ph='ku:ko'>Kuukou</phoneme> means airport",
                "<phoneme alphabet='ipa' ph='&#39;matsu ri'>Matsuri</phoneme>. <phoneme alphabet='ipa' ph='&#39;matsu ri'>Matsuri</phoneme> means festival",
                "<phoneme alphabet='ipa' ph='o kah san'>Okaasan</phoneme>. <phoneme alphabet='ipa' ph='o kah san'>Okaasan</phoneme> means mother",
                "<phoneme alphabet='ipa' ph='mu su ko'>Musuko</phoneme>. <phoneme alphabet='ipa' ph='mu su ko'>Musuko</phoneme> means son",
                "<phoneme alphabet='ipa' ph='ah ka'>Aka</phoneme>. <phoneme alphabet='ipa' ph='ah ka'>Aka</phoneme> means red",
                "<phoneme alphabet='ipa' ph='o to san'>Otousan</phoneme>. <phoneme alphabet='ipa' ph='o to san'>Otousan</phoneme> means father",
                "<phoneme alphabet='ipa' ph='ku ro'>Kuro</phoneme>. <phoneme alphabet='ipa' ph='ku ro'>Kuro</phoneme> means black"
        };
        #endregion
        #region Spanish
        private List<string> Spanish = new List<string>
        {
            "<phoneme alphabet='ipa' ph='roxo'>Rojo</phoneme>. <phoneme alphabet='ipa' ph='roxo'>Rojo</phoneme> means red",
            "<phoneme alphabet='ipa' ph='a.ˈroz'>Arroz</phoneme>. <phoneme alphabet='ipa' ph='a.ˈroz'>Arroz</phoneme> means rice.",
            "<phoneme alphabet='ipa' ph='ˈpeɾo'>Pero</phoneme>. <phoneme alphabet='ipa' ph='ˈpeɾo'>Pero</phoneme> means dog.",
            "<phoneme alphabet='ipa' ph='ˈninjo'>Niño</phoneme>. <phoneme alphabet='ipa' ph='ˈninjo'>Niño</phoneme> means boy.",
            "<phoneme alphabet='ipa' ph='aˈbwela'>Abeula</phoneme>. <phoneme alphabet='ipa' ph='aˈbwela'>Abeula</phoneme> means grandmother.",
            "<phoneme alphabet='ipa' ph='esˈkwela'>Escuela</phoneme>. <phoneme alphabet='ipa' ph='esˈkwela'>Escuela</phoneme> means school.",
            "<phoneme alphabet='ipa' ph='kaˈbesa'>Cabeza</phoneme>. <phoneme alphabet='ipa' ph='kaˈbesa'>Cabeza</phoneme> means head.",
            "<phoneme alphabet='ipa' ph='muˈse.o'>Museo</phoneme>. <phoneme alphabet='ipa' ph='muˈse.o'>Museo</phoneme> means museum.",
            "<phoneme alphabet='ipa' ph='kwerpo'>Cuerpo</phoneme>. <phoneme alphabet='ipa' ph='kwerpo'>Cuerpo</phoneme> means body.",
            "<phoneme alphabet='ipa' ph='fɾɛ.zə'>Fresa</phoneme>. <phoneme alphabet='ipa' ph='fɾɛ.zə'>Fresa</phoneme> means strawberry.",
            "<phoneme alphabet='ipa' ph='ˈdonde'>Donde</phoneme>. <phoneme alphabet='ipa' ph='ˈdonde'>Donde</phoneme> means where.",
            "<phoneme alphabet='ipa' ph='ˈpo.ko'>Poco</phoneme>. <phoneme alphabet='ipa' ph='ˈpo.ko'>Poco</phoneme> means a little bit.",
            "<phoneme alphabet='ipa' ph='ka.ˈmi.za'>Camisa</phoneme>. <phoneme alphabet='ipa' ph='ka.ˈmi.za'>Camisa</phoneme> means shirt.",
            "<phoneme alphabet='ipa' ph='ˈaɾ.bol'>Arbol</phoneme>. <phoneme alphabet='ipa' ph='ˈaɾ.bol'>Arbol</phoneme> means tree.",
            "<phoneme alphabet='ipa' ph='aˈɾaɲa'>Araña</phoneme>. <phoneme alphabet='ipa' ph='aˈɾaɲa'>Araña</phoneme> means spider.",
            "<phoneme alphabet='ipa' ph='ˈzo.ro'>Zorro</phoneme>. <phoneme alphabet='ipa' ph='ˈzo.ro'>Zorro</phoneme> means fox.",
            "<phoneme alphabet='ipa' ph='xäˈβo̞n'>Jabon</phoneme>. <phoneme alphabet='ipa' ph='xäˈβo̞n'>Jabon</phoneme> means soap.",
            "<phoneme alphabet='ipa' ph='meɾˈkado'>Mercado</phoneme>. <phoneme alphabet='ipa' ph='meɾˈkado'>Mercado</phoneme> means market",
            "<phoneme alphabet='ipa' ph='kælˈdɛɹ.ə'>Caldera</phoneme>. <phoneme alphabet='ipa' ph='kælˈdɛɹ.ə'>Caldera</phoneme> means cooking pot.",
            "<phoneme alphabet='ipa' ph='bo.ˈle.to'>Boleto</phoneme>. <phoneme alphabet='ipa' ph='bo.ˈle.to'>Boleto</phoneme> means ticket.",
            "<phoneme alphabet='ipa' ph='feˈlis'>Feliz</phoneme>. <phoneme alphabet='ipa' ph='feˈlis'>Feliz</phoneme> means happy.",
            "<phoneme alphabet='ipa' ph='elˈlunes'>El Lunes</phoneme>. <phoneme alphabet='ipa' ph='elˈlunes'>El Lunes</phoneme> means Monday.",
            "<phoneme alphabet='ipa' ph='koˈtʃiˈneɾo'>Cochinero</phoneme>. <phoneme alphabet='ipa' ph='koˈtʃiˈneɾo'>Cocinero/phoneme>means chef.",
            "<phoneme alphabet='ipa' ph='kɐ.ˈnɛ.la>Canela</phoneme>. <phoneme alphabet='ipa' ph='kɐ.ˈnɛ.la'>Canela</phoneme> means cinnamon.",
            "<phoneme alphabet='ipa' ph='konˈfiteˈria'>Confiteria</phoneme>. <phoneme alphabet='ipa' ph='konˈfiteˈria'>Confiteria</phoneme> means candy shop.",
            "<phoneme alphabet='ipa' ph='ˈplaɪə'>Playa</phoneme>. <phoneme alphabet='ipa' ph='ˈplaɪə'>Playa</phoneme> means beach",
            "<phoneme alphabet='ipa' ph='loro'>Loro</phoneme>. <phoneme alphabet='ipa' ph='loro'>Loro</phoneme> means parrot.",
            "<phoneme alphabet='ipa' ph='ˈmɛ.di.ko'>Medico</phoneme>. <phoneme alphabet='ipa' ph='ˈmɛ.di.ko'>Medico</phoneme> means doctor.",
            "<phoneme alphabet='ipa' ph='elˈme.di.oːdia'>El mediodia</phoneme>. <phoneme alphabet='ipa' ph='ˈme.di.oːdia'>El mediodia</phoneme> means noon.",
            "<phoneme alphabet='ipa' ph='ˈme̞sa'>Mesa</phoneme>. <phoneme alphabet='ipa' ph='ˈme̞sa'>Mesa</phoneme> means table.",
            "<phoneme alphabet='ipa' ph='todos'>Todos</phoneme>. <phoneme alphabet='ipa' ph='todos'>Todos</phoneme> means all.",
            "<phoneme alphabet='ipa' ph='ko̞ˈtʃi.na̠'>Cocina</phoneme>. <phoneme alphabet='ipa' ph='ko̞ˈtʃi.na̠'>Cocina</phoneme> means kitchen.",
            "<phoneme alphabet='ipa' ph='ɐˈβɾiɣo'>Abrigo</phoneme>. <phoneme alphabet='ipa' ph='ɐˈβɾiɣo'>Abrigo</phoneme> means coat.",
            "<phoneme alphabet='ipa' ph='sjen'>Cien</phoneme>. <phoneme alphabet='ipa' ph='sjen'>Cien</phoneme> means one hundred.",
            "<phoneme alphabet='ipa' ph='xeˈmelo'>Gemelo</phoneme>. <phoneme alphabet='ipa' ph='xeˈmelo'>Gemelo</phoneme> means twin.",
            "<phoneme alphabet='ipa' ph='ˈsjem.pɾe'>Siempre</phoneme>. <phoneme alphabet='ipa' ph='ˈsjem.pɾe'>Siempre</phoneme> means always.",
            "<phoneme alphabet='ipa' ph='ˈpa.na.ðeˈɾi.a'>Panaderia</phoneme>. <phoneme alphabet='ipa' ph='ˈpa.na.ðeˈɾi.a'>Panaderia</phoneme> means bakery.",
            "<phoneme alphabet='ipa' ph='ˈmar'>Mar</phoneme>. <phoneme alphabet='ipa' ph='ˈmar'>Jikan</phoneme> means ocean.",
            "<phoneme alphabet='ipa' ph='oso'>Oso</phoneme>. <phoneme alphabet='ipa' ph='oso'>Oso</phoneme> means bear.",
            "<phoneme alphabet='ipa' ph='ˈɡwa.po'>Guapo</phoneme>. <phoneme alphabet='ipa' ph='ˈɡwa.po'>Guapo</phoneme> means handsome.",
            "<phoneme alphabet='ipa' ph='ˈoi̯'>Hoy</phoneme>. <phoneme alphabet='ipa' ph='ˈoi̯'>Hoy</phoneme> means today",
            "<phoneme alphabet='ipa' ph='almoˈada'>Almohada</phoneme>. <phoneme alphabet='ipa' ph='almoˈada'>Almohada</phoneme> means pillow.",
            "<phoneme alphabet='ipa' ph='anaɾanˈxado'>Anaranjado</phoneme>. <phoneme alphabet='ipa' ph='anaɾanˈxado'>Anaranjado</phoneme> means orange.",
            "<phoneme alphabet='ipa' ph='manˈzana'>Manzana</phoneme>. <phoneme alphabet='ipa' ph='manˈzana'>Manzana</phoneme> means apple.",
            "<phoneme alphabet='ipa' ph='reino'>Reino</phoneme>. <phoneme alphabet='ipa' ph='reino'>Reino</phoneme> means kingdom.",
            "<phoneme alphabet='ipa' ph='ˈfut.bɔɫ'>Futbol</phoneme>. <phoneme alphabet='ipa' ph='ˈfut.bɔɫ'>Futbol</phoneme> means Football or Soccer. Depending on where you live.",
            "<phoneme alphabet='ipa' ph='ma.ˈɾi.do'>Marido</phoneme>. <phoneme alphabet='ipa' ph='ma.ˈɾi.do'>Marido</phoneme> means husband.",
            "<phoneme alphabet='ipa' ph='ˈmälo̞'>Malo</phoneme>. <phoneme alphabet='ipa' ph='ˈmälo̞'>Malo</phoneme> means bad.",
            "<phoneme alphabet='ipa' ph='ˈpasado maˈɲana'>Pasado mañana</phoneme>. <phoneme alphabet='ipa' ph='ˈpasado maˈɲana'>Pasado mañana</phoneme> means the day after tomorrow.",
            "<phoneme alphabet='ipa' ph='ˈxuljo'>Julio</phoneme>. <phoneme alphabet='ipa' ph='ˈxuljo'>Julio</phoneme> means July.",
            "<phoneme alphabet='ipa' ph='ˈnu.βe'>Nube</phoneme>. <phoneme alphabet='ipa' ph='ˈnu.βe'>Nube</phoneme> means cloud.",
            "<phoneme alphabet='ipa' ph='sa.ˈka(ɹ) un ˈfoto'>Sacar un foto</phoneme>. <phoneme alphabet='ipa' ph='sa.ˈka(ɹ) un ˈfoto'>Sacar un foto</phoneme> means to take a picture.",
            "<phoneme alphabet='ipa' ph='ɡi.ˈta.ʁa'>Guitarra</phoneme>. <phoneme alphabet='ipa' ph='ɡi.ˈta.ʁa'>Guitarra</phoneme> means guitar.",
            "<phoneme alphabet='ipa' ph='ˈka.ma'>Cama</phoneme>. <phoneme alphabet='ipa' ph='ˈka.ma'>Cama</phoneme> means bed.",
            "<phoneme alphabet='ipa' ph='is.ˈtɔ.ɾi.ko'>Historico</phoneme>. <phoneme alphabet='ipa' ph='is.ˈtɔ.ɾi.ko'>Historico</phoneme> means historical.",
            "<phoneme alphabet='ipa' ph='ˈbɾaso'>Brazo</phoneme>. <phoneme alphabet='ipa' ph='ˈbɾaso'>Brazo</phoneme> means arm.",
            "<phoneme alphabet='ipa' ph='ˈplumas'>Plumas</phoneme>. <phoneme alphabet='ipa' ph='ˈplumas'>Plumas</phoneme> means feathers.",
            "<phoneme alphabet='ipa' ph='di.ˈfi.siɫ'>Dificil</phoneme>. <phoneme alphabet='ipa' ph='di.ˈfi.siɫ'>Dificil</phoneme> means difficult.",
            "<phoneme alphabet='ipa' ph='kaˈβajo'>Caballo</phoneme>. <phoneme alphabet='ipa' ph='kaˈβajo'>Caballo</phoneme> means horse.",
            "<phoneme alphabet='ipa' ph='su.perˈfi.si.e'>Superficie</phoneme>. <phoneme alphabet='ipa' ph='su.perˈfi.si.e'>Superficie</phoneme> means surface.",
            "<phoneme alphabet='ipa' ph='kanˈtar'>Cantar</phoneme>. <phoneme alphabet='ipa' ph='kanˈtar'>Cantar</phoneme> means to sing.",
            "<phoneme alphabet='ipa' ph='bibljoˈteka'>Biblioteca</phoneme>. <phoneme alphabet='ipa' ph='bibljoˈteka'>Biblioteca</phoneme> means library.",
            "<phoneme alphabet='ipa' ph='e̞sˈtɾe̞.ja'>Estrella</phoneme>. <phoneme alphabet='ipa' ph='e̞sˈtɾe̞.ja'>Estrella</phoneme> means star.",
            "<phoneme alphabet='ipa' ph='ˈnieta'>Nieta</phoneme>. <phoneme alphabet='ipa' ph='ˈnieta'>Nieta</phoneme> means granddaughter.",
            "<phoneme alphabet='ipa' ph='mo.ˈɾa.da'>Morada</phoneme>. <phoneme alphabet='ipa' ph='mo.ˈɾa.da'>Morada</phoneme> means purple.",
            "<phoneme alphabet='ipa' ph='ˈle̞tʃe̞'>Leche</phoneme>. <phoneme alphabet='ipa' ph='ˈle̞tʃe̞'>Leche</phoneme> means milk.",
            "<phoneme alphabet='ipa' ph='pɾiˈmeɾo'>Primero</phoneme>. <phoneme alphabet='ipa' ph='pɾiˈmeɾo'>Primero</phoneme> means first.",
            "<phoneme alphabet='ipa' ph='aˈbjerto'>Abierto</phoneme>. <phoneme alphabet='ipa' ph='aˈbjerto'>Abierto</phoneme> means open.",
            "<phoneme alphabet='ipa' ph='soːl'>Sol</phoneme>. <phoneme alphabet='ipa' ph='soːl'>Sol</phoneme> means sun.",
            "<phoneme alphabet='ipa' ph='ɛspəɹˈanzə'>Esperanza</phoneme>. <phoneme alphabet='ipa' ph='ɛspəɹˈanzə'>Esperanza</phoneme> means hope.",
            "<phoneme alphabet='ipa' ph='diˈsjembɾe'>Diciembre</phoneme>. <phoneme alphabet='ipa' ph='diˈsjembɾe'>Diciembre</phoneme> means December.",
            "<phoneme alphabet='ipa' ph='esˈpesja'>Especia</phoneme>. <phoneme alphabet='ipa' ph='esˈpesja'>Especia</phoneme> means spice.",
            "<phoneme alphabet='ipa' ph='la madɾuˈɡada'>La madrugada</phoneme>. <phoneme alphabet='ipa' ph='la madɾuˈɡada'>La madrugada</phoneme> means dawn.",
            "<phoneme alphabet='ipa' ph='ˈwe.vo'>Huevo</phoneme>. <phoneme alphabet='ipa' ph='ˈwe.vo'>Huevo</phoneme> means egg.",
            "<phoneme alphabet='ipa' ph='xuˈɡar'>Jugar</phoneme>. <phoneme alphabet='ipa' ph='xuˈɡar'>Jugar</phoneme> means to play.",
            "<phoneme alphabet='ipa' ph='no.ˈvɛ.la'>Novela</phoneme>. <phoneme alphabet='ipa' ph='no.ˈvɛ.la'>Novela</phoneme> means novel.",
            "<phoneme alphabet='ipa' ph='ˈisla'>Isla</phoneme>. <phoneme alphabet='ipa' ph='ˈisla'>Isla</phoneme> means island.",
            "<phoneme alphabet='ipa' ph='eskɾiˈtor'>Escritor</phoneme>. <phoneme alphabet='ipa' ph='eskɾiˈtor'>Escritor</phoneme> means author.",
            "<phoneme alphabet='ipa' ph='elˈnorte'>El norte</phoneme>. <phoneme alphabet='ipa' ph='elˈnorte'>El norte</phoneme> means north.",
            "<phoneme alphabet='ipa' ph='ˈdedo'>Dedo</phoneme>. <phoneme alphabet='ipa' ph='ˈdedo'>Dedo</phoneme> means finger.",
            "<phoneme alphabet='ipa' ph='elˈvjernes'>El viernes</phoneme>. <phoneme alphabet='ipa' ph='elˈvjernes'>El viernes</phoneme> means Friday.",
            "<phoneme alphabet='ipa' ph='esˈposa'>Esposa</phoneme>. <phoneme alphabet='ipa' ph='esˈposa'>Esposa</phoneme> means wife.",
            "<phoneme alphabet='ipa' ph='ˈvjento'>Viento</phoneme>. <phoneme alphabet='ipa' ph='ˈvjento'>Viento</phoneme> means wind.",
            "<phoneme alphabet='ipa' ph='ˈtiːo'>Tio</phoneme>. <phoneme alphabet='ipa' ph='ˈtiːo'>Tio</phoneme> means uncle.",
            "<phoneme alphabet='ipa' ph='ˈdia/'>Dia</phoneme>. <phoneme alphabet='ipa' ph='ˈdia/'>Dia</phoneme> means day.",
            "<phoneme alphabet='ipa' ph='pɾeˈɡun.ta'>Pregunta</phoneme>. <phoneme alphabet='ipa' ph='pɾeˈɡun.ta'>Pregunta</phoneme> means question.",
            "<phoneme alphabet='ipa' ph='saˈpat̪os'>Zapatos</phoneme>. <phoneme alphabet='ipa' ph='saˈpat̪os'>Zapatos</phoneme> means the shoes.",
            "<phoneme alphabet='ipa' ph='seˈmija'>Semilla</phoneme>. <phoneme alphabet='ipa' ph='seˈmija'>Semilla</phoneme> means seed.",
            "<phoneme alphabet='ipa' ph='estuˈdiar'>Estudiar</phoneme>. <phoneme alphabet='ipa' ph='estuˈdiar'>Estudiar</phoneme> means to study.",
            "<phoneme alphabet='ipa' ph='ɡusˈtar'>Gustar</phoneme>. <phoneme alphabet='ipa' ph='ɡusˈtar'>Gustar</phoneme> means to like.",
            "<phoneme alphabet='ipa' ph='ˈweso'>Hueso</phoneme>. <phoneme alphabet='ipa' ph='ˈweso'>Hueso</phoneme> means bone.",
            "<phoneme alphabet='ipa' ph='el doˈminɡo'>El domingo</phoneme>. <phoneme alphabet='ipa' ph='el doˈminɡo'>El domingo</phoneme> means Sunday.",
            "<phoneme alphabet='ipa' ph='kiˈsas'>Quizas</phoneme>. <phoneme alphabet='ipa' ph='kiˈsas'>Quizas</phoneme> means perhaps.",
            "<phoneme alphabet='ipa' ph='aˈbɾil'>Abril</phoneme>. <phoneme alphabet='ipa' ph='aˈbɾil'>Abril</phoneme> means April.",
            "<phoneme alphabet='ipa' ph='ˈbaŋko'>Banco</phoneme>. <phoneme alphabet='ipa' ph='ˈbaŋko'>Banco</phoneme> means bank.",
            "<phoneme alphabet='ipa' ph='ˈkoɾason'>Corazon</phoneme>. <phoneme alphabet='ipa' ph='ˈkoɾason'>Corazon</phoneme> means heart.",
            "<phoneme alphabet='ipa' ph='ˈtjendas'>Tiendas</phoneme>. <phoneme alphabet='ipa' ph='ˈtjendas'>Tiendas</phoneme> means shops.",
            "<phoneme alphabet='ipa' ph='mariˈposa'>Mariposa</phoneme>. <phoneme alphabet='ipa' ph='mariˈposa'>Mariposa</phoneme> means butterfly.",
            "<phoneme alphabet='ipa' ph='ˈa.ɣi.la'>Aguila</phoneme>. <phoneme alphabet='ipa' ph='ˈa.ɣi.la'>Aguila</phoneme> means eagle.",
            "<phoneme alphabet='ipa' ph='la ˈtaɻ.de'>La tarde</phoneme>. <phoneme alphabet='ipa' ph='la ˈtaɻ.de'>La tarde</phoneme> means afternoon."
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
                case "spanish": TodaysWord = Spanish[((int)Day % Spanish.Count())]; break;
                //case "french": TodaysWord = French[((int)Day % French.Count())]; break;
                //case "italian": TodaysWord = Italian[((int)Day % Italian.Count())]; break;
                //case "german": TodaysWord = German[((int)Day % German.Count())]; break;
                default: TodaysWord = "Sorry, URL is invalid. Please contact us at www.LostDutchmanSoftware.com"; break;
            }

            TodaysWord += ". Please visit Lost Dutchman dot itch dot eye oh and try our new retro inspired sumo game.";

            return TodaysWord;
        }
    }
}