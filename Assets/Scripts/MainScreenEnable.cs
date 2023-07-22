using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainScreenEnable : MonoBehaviour
{
    [SerializeField]
    private Image speak500Image;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        float timer = 0;

        while(timer < 1)
        {
            timer += Time.deltaTime;
            speak500Image.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, timer / 1));
            yield return null;
        }
        speak500Image.enabled = false;
    }
}
