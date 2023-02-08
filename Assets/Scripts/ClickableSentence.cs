using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickableSentence : MonoBehaviour, IPointerClickHandler
{
    private TextMeshProUGUI text;

    public static event System.Action<string> Clicked;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("f");
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, null);

        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];

            Debug.Log(linkInfo.GetLinkText().Replace("\"", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(" ", "").ToLower());

            Clicked?.Invoke(linkInfo.GetLinkText().Replace("\"", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(" ", ""));
        }
        print("f");
    }
}

/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickableSentence : MonoBehaviour, IPointerClickHandler
{
    private TextMeshProUGUI text;

    public static event System.Action<string> Clicked;

    private void Awake()
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(transform.parent.parent.parent.GetComponent<RectTransform>().rect.width - 100, 900);
        text = GetComponent<TextMeshProUGUI>();

        text.fontSize = 70 * (int)(transform.parent.parent.parent.GetComponent<RectTransform>().rect.width / 800f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, null);

        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = text.textInfo.linkInfo[linkIndex];

            Debug.Log(linkInfo.GetLinkText().Replace("\"", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(" ", "").ToLower());

            Clicked?.Invoke(linkInfo.GetLinkText().Replace("\"", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Replace(" ", ""));
        }
    }
}
 * 
 */
