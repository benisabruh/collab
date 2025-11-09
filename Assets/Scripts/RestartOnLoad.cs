using UnityEngine;

public class RestartOnLoad : MonoBehaviour
{
    public GameObject restartTextObject;

    void Awake()
    {
        if (PlayerPrefs.GetInt("showRestart", 0) != 1) return;

        PlayerPrefs.SetInt("showRestart", 0);
        PlayerPrefs.Save();

        if (restartTextObject != null)
        {
            restartTextObject.SetActive(true);
            return;
        }

        var child = transform.Find("Restart") ?? transform.Find("Text");
        if (child != null)
        {
            child.gameObject.SetActive(true);
            return;
        }

        var uiText = GetComponentInChildren<UnityEngine.UI.Text>(true);
        if (uiText != null)
        {
            uiText.gameObject.SetActive(true);
            return;
        }

        var tmp = GetComponentInChildren<TMPro.TextMeshProUGUI>(true);
        if (tmp != null)
        {
            tmp.gameObject.SetActive(true);
            return;
        }
    }
}
