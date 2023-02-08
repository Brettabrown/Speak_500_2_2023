using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LanguageView : MonoBehaviour
{
    [SerializeField]
    private Button languageSelectButtonPrefab;

    [SerializeField]
    private Transform buttonParent;

    [SerializeField]
    private Translator translator;

    private void Awake()
    {
        for(int i = 0; i < System.Enum.GetValues(typeof(LanguageEnum.Languages)).Length; i++)
        {
            Button button = Instantiate(languageSelectButtonPrefab, buttonParent);
            button.GetComponentInChildren<Text>().text = LanguageEnum.LanguageNames[i];
            int _i = i;
            button.onClick.AddListener(() => translator.CurrentLanguage = (LanguageEnum.Languages)_i);
        }
    }
}
