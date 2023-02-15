using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneView : MonoBehaviour
{
    [SerializeField]
    private Button languageSelectButtonPrefab;

    [SerializeField]
    private Transform buttonParent;

    [SerializeField]
    private SceneLoader sceneLoader;

    [SerializeField]
    private MainTextArea mainTextArea;

    private void Start()
    {
        for(int i = 0; i < sceneLoader.scenes.Count; i++)
        {
            Scene scene = sceneLoader.scenes[i];
            Button button = Instantiate(languageSelectButtonPrefab, buttonParent);
            button.GetComponentInChildren<Text>().text = scene.name;
            button.onClick.AddListener(() => mainTextArea.SwitchScene(scene));
        }
    }

}
