using UnityEngine;

public class Translator : MonoBehaviour
{
    public event System.Action LanguageChanged;
    public LanguageEnum.Languages CurrentLanguage { get { return currentLanguage; } set { currentLanguage = value; LanguageChanged?.Invoke(); } }

    private LanguageEnum.Languages currentLanguage;
}
