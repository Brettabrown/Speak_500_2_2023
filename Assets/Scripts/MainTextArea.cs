using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class MainTextArea : MonoBehaviour
{
    public int currentLine;

    [SerializeField]
    private TextMeshProUGUI clickableText;

    [SerializeField]
    private Text translationText;


    [SerializeField]
    private Scene currentScene;

    [SerializeField]
    private SceneLoader sceneLoader;

    [SerializeField]
    private Translator translator;

    [SerializeField]
    private MainVideoPlayer videoPlayer;

    [SerializeField]
    private Text textPrefab;

    [SerializeField]
    private TextMeshProUGUI tmpPrefab;

    [SerializeField]
    private GameObject scrollView;

    [SerializeField]
    private Transform scrollViewContent;

    [SerializeField]
    private Transform spacer;

    [SerializeField]
    private GameObject selectScene;

    private void Start()
    {
        translator.LanguageChanged += ShowText;
        translator.LanguageChanged += UpdateShowAll;
        currentLine = -1;
        currentScene = sceneLoader.scenes[0];
        //SwitchScene(sceneLoader.scenes[0]);
        ShowText();
        UpdateShowAll();
        HideAll();
    }

    public void SwitchScene(Scene scene)
    {
        selectScene.SetActive(false);
        currentLine = -1;
        currentScene = scene;
        videoPlayer.SetURL($"https://eofenglish.com/SSSE/500_Video/{scene.sceneData.videoClipName}.mp4");
        ShowText();
        UpdateShowAll();
    }

    private void UpdateShowAll()
    {
        foreach(Transform transform in scrollViewContent)
        {
            Destroy(transform.gameObject);
        }
        foreach(var sentence in currentScene.sentences)
        {
            TextMeshProUGUI text = Instantiate(tmpPrefab, scrollViewContent);
            //text.text = sentence.sentencesTranslated[0];
            string[] sentenceSplit = sentence.sentencesTranslated[0].Split(' ');
            string ltext = sentenceSplit[0] + " ";
            for (int i = 1; i < sentenceSplit.Length; i++)
            {
                ltext += "<link=\"Word>" + sentenceSplit[i] + " </link>";
            }
            text.text = ltext;
            if (translator.CurrentLanguage != LanguageEnum.Languages.English)
            {
                //Instantiate(spacer, scrollViewContent);
                Text _text = Instantiate(textPrefab, scrollViewContent);
                _text.text = sentence.sentencesTranslated[(int)translator.CurrentLanguage];
            }
            Instantiate(spacer, scrollViewContent);
        }
    }

    private void Update()
    {
        int line = GetCurrentLineNumber();
        if (currentLine != line)
        {
            currentLine = line;
            ShowText();
        }
    }

    private int GetCurrentLineNumber()
    {
        for (int i = 0; i < currentScene.sceneData.sentenceStartTimes.Length; i++)
        {
            if (videoPlayer.Time < currentScene.sceneData.sentenceStartTimes[i])
            {
                return i - 1;
            }
        }
        return currentScene.sceneData.sentenceStartTimes.Length - 1;
    }

    private void ShowText()
    {
        if (currentLine < 0)
        {
            clickableText.text = "";
            translationText.text = "";
            return;
        }
        string[] sentenceSplit = currentScene.sentences[currentLine].sentencesTranslated[0].Split(' ');
        string text = sentenceSplit[0] + " ";
        for (int i = 1; i < sentenceSplit.Length; i++)
        {
            text += "<link=\"Word>" + sentenceSplit[i] + " </link>";
        }
        clickableText.text = text;

        if (translator.CurrentLanguage == LanguageEnum.Languages.English)
        {
            translationText.text = "";
        }
        else
        {
            translationText.text = currentScene.sentences[currentLine].sentencesTranslated[(int)translator.CurrentLanguage];
        }
    }

    public void ShowAll()
    {
        scrollView.SetActive(true);
        clickableText.gameObject.SetActive(false);
        translationText.gameObject.SetActive(false);
    }

    public void HideAll()
    {
        scrollView.SetActive(false);
        clickableText.gameObject.SetActive(true);
        translationText.gameObject.SetActive(true);
    }
}
