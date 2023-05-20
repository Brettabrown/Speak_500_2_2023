using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private TextAsset loadableScene;

    public List<Scene> scenes;

    private void Awake()
    {
        scenes = new List<Scene>();

        string[] content = loadableScene.text.Split('\n');
        Scene scene = null;
        foreach (string line in content)
        {
            if (line.Length > 0 && line[0] == '#')
            {
                if (scene != null)
                {
                    scenes.Add(scene);
                }
                scene = new Scene();
                scene.name = line.Replace("#", "").Trim();
                print(scene.name);
                scene.sentences = new List<Sentence>();
                scene.sceneData = (SceneData)Resources.Load(scene.name.Replace(' ', '_'), typeof(SceneData));
            }
            else
            {
                string[] sentences = line.Split('█');
                if (sentences.Length < System.Enum.GetValues(typeof(LanguageEnum.Languages)).Length)
                {
                    Debug.LogError($"Scene: {scene.name}. Sentence doesn't contain all languages!: {line}");
                }
                scene.sentences.Add(new Sentence() { sentencesTranslated = sentences.ToList() });
            }
        }
        scenes.Add(scene);
    }

}

[System.Serializable]
public class Scene
{
    public string name;
    public SceneData sceneData;
    public List<Sentence> sentences;
}

[System.Serializable]
public class Sentence
{
    public List<string> sentencesTranslated;
}