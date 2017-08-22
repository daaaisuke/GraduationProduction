using UnityEngine;
using UnityEngine.UI;

public class ColorControlWithWatson : MonoBehaviour {

    public GameObject output;

    private string previousText = "";
    private Color color;

	// Use this for initialization
	void Start () {

        color = Color.yellow;
    }

    // Update is called once per frame
    void Update () {

        Text outputText = output.GetComponent<Text>();

        if (outputText.text != previousText)
        {

            if (outputText.text.Contains("赤色")) color = Color.red;
            if (outputText.text.Contains("緑色")) color = Color.green;
            if (outputText.text.Contains("青色")) color = Color.blue;

            GetComponent<Renderer>().material.SetColor("_Color", color);
            Debug.Log(outputText.text);
            Debug.Log(color);

            previousText = outputText.text;
        }
    }
}
