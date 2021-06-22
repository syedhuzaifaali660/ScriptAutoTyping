using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AutoTyping : MonoBehaviour
{

    public string story;
    // Start is called before the first frame update
    void OnEnable()
    {
        this.GetComponent<Text>().text = "";
        StartCoroutine(PlayText());
    }
    IEnumerator PlayText()
    {
        foreach (char c in story)
        {
            this.GetComponent<Text>().text += c.ToString();
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }


}
