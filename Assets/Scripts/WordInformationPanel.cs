using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class WordInformationPanel : MonoBehaviour
{

    [SerializeField]
    private GameObject panel;

    [SerializeField]
    private MainVideoPlayer mainVideoPlayer;

    [SerializeField]
    private TextMeshProUGUI englishWord;

    [SerializeField]
    private TextMeshProUGUI ipa;

    [SerializeField]
    private TextMeshProUGUI bpa;

    [SerializeField]
    private Text translation;

    [SerializeField]
    private Translator translator;

    private Dictionary<string, AudioClip> clipCache;

    [SerializeField]
    private Button audioButton;

    [SerializeField]
    private AudioSource audioSource;

    private void Awake()
    {
        clipCache = new Dictionary<string, AudioClip>();
        ClickableSentence.Clicked += Show;
    }

    private void Show(string word)
    {
        panel.SetActive(true);
        if (!WordLoader.wordsDict.ContainsKey(word))
        {
            word = word.ToLower();
        }

        englishWord.text = word;
        ipa.text = WordLoader.wordsDict[word].IPA;
        bpa.text = WordLoader.wordsDict[word].BPA;
        if (translator.CurrentLanguage == LanguageEnum.Languages.English)
        {
            translation.text = "";
        }
        else
        {
            translation.text = WordLoader.wordsDict[word].translations[(int)translator.CurrentLanguage];
        }


        audioButton.onClick.RemoveAllListeners();
        audioButton.onClick.AddListener(() => StartCoroutine(PlayWord(word)));

    }

    private IEnumerator PlayWord(string word)
    {
        if(!clipCache.ContainsKey(word))
        {
            var request = UnityWebRequestMultimedia.GetAudioClip($"https://eofenglish.com/SSSE/Audio/{word}.mp3", AudioType.MPEG);
            yield return request.SendWebRequest();
            var clip = DownloadHandlerAudioClip.GetContent(request);
            clipCache.Add(word, clip);
        }
        audioSource.clip = clipCache[word];
        audioSource.Play();
    }


    public void Back()
    {
        panel.SetActive(false);
        mainVideoPlayer.WordEnd();
    }
}
