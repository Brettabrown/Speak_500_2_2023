using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageEnum : MonoBehaviour
{
    public enum Languages
    {
        English,
        Afrikaans,
        Albanian,
        Amharic,
        Arabic,
        Armenian,
        Assamese,
        Aymara,
        Azerbaijani,
        Bambara,
        Basque,
        Belarusian,
        Bengali,
        Bhojpuri,
        Bosnian,
        Bulgarian,
        Catalan,
        Cebuano,
        Chichewa,
        ChineseSimplified,
        Corsican,
        Croatian,
        Czech,
        Danish,
        Dhivehi,
        Dogri,
        Dutch,
        Esperanto,
        Estonian,
        Ewe,
        Filipino,
        Finnish,
        French,
        Frisian,
        Galician,
        Georgian,
        German,
        Greek,
        Guarani,
        Gujarati,
        HaitianCreole,
        Hausa,
        Hawaiian,
        Hebrew,
        Hindi,
        Hmong,
        Hungarian,
        Icelandic,
        Igbo,
        Ilocano,
        Indonesian,
        Irish,
        Italian,
        Japanese,
        Javanese,
        Kannada,
        Kazakh,
        Khmer,
        Kinyarwanda,
        Konkani,
        Korean,
        Krio,
        KurdishKurmanji,
        KurdishSorani,
        Kyrgyz,
        Lao,
        Latin,
        Latvian,
        Lingala,
        Lithuanian,
        Luganda,
        Luxembourgish,
        Macedonian,
        Maithili,
        Malagasy,
        Malay,
        Malayalam,
        Maltese,
        Maori,
        Marathi,
        MeiteilonManipuri,
        Mizo,
        Mongolian,
        MyanmarBurmese,
        Nepali,
        Norwegian,
        OdiaOriya,
        Oromo,
        Pashto,
        Persian,
        Polish,
        Portuguese,
        Punjabi,
        Quechua,
        Romanian,
        Russian,
        Samoan,
        Sanskrit,
        ScotsGaelic,
        Sepedi,
        Serbian,
        Sesotho,
        Shona,
        Sindhi,
        Sinhala,
        Slovak,
        Slovenian,
        Somali,
        Spanish,
        Sundanese,
        Swahili,
        Swedish,
        Tajik,
        Tamil,
        Tatar,
        Telugu,
        Thai,
        Tigrinya,
        Tsonga,
        Turkish,
        Turkmen,
        Twi,
        Ukrainian,
        Urdu,
        Uyghur,
        Uzbek,
        Vietnamese,
        Welsh,
        Xhosa,
        Yiddish,
        Yoruba,
        Zulu,
    }

    public static string[] LanguageNames =
    {
        "English",
        "Afrikaans",
        "Albanian shqiptare",
        "Amharic አማርኛ",
        "Arabic عربي",
        "Armenian հայերեն",
        "Assamese অসমীয়া",
        "Aymara ",
        "Azerbaijan Azərbaycan",
        "Bambara Bamanankan",
        "Basque euskara",
        "Belarusian беларускі",
        "Bengali বাংলা",
        "Bhojpuri भोजपुरी",
        "Bosnian bosanski",
        "Bulgarian български",
        "Catalan català",
        "Cebuano ",
        "Chichewa",
        "Chinese (Simplified) 中国人",
        "Corsican Corsu",
        "Croatian Hrvatski",
        "Czech čeština",
        "Danish dansk",
        "Divehi ދިވެހި...",
        "Dogri डोगरी",
        "Dutch Nederlands",
        "Esperanto Esperanto",
        "Estonian eesti keel",
        "Ewe Eʋegbe",
        "Filipino ",
        "Finnish Suomalainen",
        "French Français",
        "Frisian Frysk",
        "Galician galego",
        "Georgian ქართული",
        "German Deutsch",
        "Greek Ελληνικά",
        "Guarani ",
        "Gujarati ગુજરાતી",
        "Haitian Creole Kreyòl ayisyen",
        "Hausa ",
        "Hawaiian ʻŌlelo Hawaiʻi",
        "Hebrew עִברִית",
        "Hindi हिंदी",
        "Hmong Hmoob",
        "Hungarian Magyar",
        "Icelandic íslenskur",
        "Igbo ",
        "Ilocano",
        "Indonesian bahasa Indonesia",
        "Irish Gaeilge",
        "Italian Italiana",
        "Japanese 日本",
        "Javanese basa jawa",
        "Kannada ಕನ್ನಡ",
        "Kazakh қазақ",
        "Khmer ខ្មែរ",
        "Kinyarwanda",
        "Konkani कोंकणी",
        "Korean 한국인",
        "Krio ",
        "Kurdish (Kurmanji) Kurdî (Kurmancî)",
        "Kurdish (Sorani) کوردی (سۆرانی)",
        "Kyrgyz Кыргызча",
        "Lao ພາສາລາວ",
        "Latin Latinus",
        "Latvian latviski",
        "Lingala ",
        "Lithuanian lietuvių",
        "Luganda Ganda",
        "Luxembourgish lëtzebuergesch",
        "Macedonian македонски",
        "Maithili मैथिली",
        "Malagasy ",
        "Malay Melayu",
        "Malayalam മലയാളം",
        "Maltese  Malti",
        "Maori ",
        "Marathi मराठी",
        "Meiteilon (Manipuri) ꯃꯦꯏꯇꯦꯏꯂꯣꯟ (ꯃꯅꯤꯄꯨꯔꯤ) ꯴.",
        "Mizo Mizo tawng",
        "Mongolian Монгол",
        "Myanmar (Burmese) မြန်မာ (ဗမာ)၊",
        "Nepali नेपाली",
        "Norwegian norsk",
        "Odia ଓଡିଆ",
        "Oromo Afaan Oromoo",
        "Pashto پښتو",
        "Persian فارسی",
        "Polish Polski",
        "Portuguese Português",
        "Punjabi ਪੰਜਾਬੀ",
        "Quechua Runasimi",
        "Romanian Română",
        "Russian Русский",
        "Samoan Samoa",
        "Sanskrit संस्कृत",
        "Scottish Gaelic Gàidhlig na h-Alba",
        "Sepedi",
        "Serbian Српски",
        "Sesotho",
        "Shona ",
        "Sindhi سنڌي",
        "Sinhala සිංහල",
        "Slovak slovenský",
        "Slovenian Slovenščina",
        "Somali Soomaali",
        "Spanish Española",
        "Sundanese basa Sunda",
        "Swahili kiswahili",
        "Swedish svenska",
        "Tajik тоҷикӣ",
        "Tamil தமிழ்",
        "Tatar Татар",
        "Telugu తెలుగు",
        "Thai แบบไทย",
        "Tigrinya ትግሪኛ",
        "Tsonga",
        "Turkish Türk",
        "Turkmen Türkmenler",
        "Twi ",
        "Ukrainian українська ",
        "Urdu اردو",
        "Uyghur ئۇيغۇر",
        "Uzbek o'zbek",
        "Vietnamese Tiếng Việt",
        "Welsh Cymraeg",
        "Xhosa isiXhosa",
        "Yiddish יידיש",
        "Yoruba ",
        "Zulu"
    };
}
