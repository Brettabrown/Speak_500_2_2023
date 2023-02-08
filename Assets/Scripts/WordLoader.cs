using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class WordLoader : MonoBehaviour
{
    public TextAsset loadableWords;

    [SerializeField]
    private bool LoadWords;

    [SerializeField]
    private List<Word> words;

    public static Dictionary<string, Word> wordsDict;

    private void Awake()
    {
        words = new List<Word>();
        wordsDict = new Dictionary<string, Word>();
        string[] content = loadableWords.text.Split('\n');
        foreach (string line in content)
        {
            string[] _words = line.Split('	');
            Word word = new Word()
            {
                IPA = _words[1],
                BPA = _words[2],
                translations = new List<string>(),
            };
            word.translations.Add(_words[0]);
            word.translations.AddRange(_words.Skip(3).ToList());
            words.Add(word);
            try
            {
                wordsDict.Add(_words[0], word);
            }
            catch(System.Exception e)
            {
                Debug.LogWarning(e);
            }
        }

    }
}

[System.Serializable]
public class Word
{
    public string IPA;
    public string BPA;
    public List<string> translations;
}
