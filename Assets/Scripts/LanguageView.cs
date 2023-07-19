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


    [SerializeField]
    private Sprite offSprite;

    [SerializeField]
    private Sprite onSprite;

    private void Awake()
    {
        int selected = PlayerPrefs.GetInt("Language", 0);
        translator.CurrentLanguage = (LanguageEnum.Languages)selected;
        for (int i = 0; i < System.Enum.GetValues(typeof(LanguageEnum.Languages)).Length; i++)
        {
            Button button = Instantiate(languageSelectButtonPrefab, buttonParent);
            button.GetComponentInChildren<Text>().text = LanguageEnum.LanguageNames[i];
            int _i = i;
            button.onClick.AddListener(() =>
            {
                translator.CurrentLanguage = (LanguageEnum.Languages)_i;
                PlayerPrefs.SetInt("Language", _i);

                foreach (Transform transform in buttonParent)
                {
                    transform.GetComponent<Image>().sprite = offSprite;
                }

                button.GetComponent<Image>().sprite = onSprite;

            });
        }

        buttonParent.GetChild(selected).GetComponent<Image>().sprite = onSprite;
    }
}
