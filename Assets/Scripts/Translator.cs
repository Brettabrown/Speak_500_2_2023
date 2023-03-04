using UnityEngine;


public class Translator : MonoBehaviour
{
    [SerializeField]
    private Font defaultFont;

    [SerializeField]
    private Font khmerFont;

    [SerializeField]
    private Font burmeseFont;

    [SerializeField]
    private Font amharicFont;

    [SerializeField]
    private Font dhivehiFont;

    private static Font DefaultFont;
    private static Font KhmerFont;
    private static Font BurmeseFont;
    private static Font AmharicFont;
    private static Font DhivehiFont;


    private void Awake()
    {
        DefaultFont = defaultFont;
        KhmerFont = khmerFont;
        BurmeseFont = burmeseFont;
        AmharicFont = amharicFont;
        DhivehiFont = dhivehiFont;
    }


    public static Font GetFont(LanguageEnum.Languages language)
    {
        switch (language)
        {
            case LanguageEnum.Languages.Khmer:
                return KhmerFont;
            case LanguageEnum.Languages.MyanmarBurmese:
                return BurmeseFont;
            case LanguageEnum.Languages.Amharic:
                return AmharicFont;
            case LanguageEnum.Languages.Dhivehi:
                return DhivehiFont;
            default:
                return DefaultFont;
        }
    }


    public event System.Action LanguageChanged;
    public LanguageEnum.Languages CurrentLanguage { get { return currentLanguage; } set { currentLanguage = value; LanguageChanged?.Invoke(); } }

    private LanguageEnum.Languages currentLanguage;
}