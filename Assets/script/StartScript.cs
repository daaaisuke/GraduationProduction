using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	public GameObject output;

	private string previousText = "";
	float alpha =0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Text outputText = output.GetComponent<Text>();

		if (outputText.text.Contains ("スタート")) {
			alpha += 0.03f;
			this.GetComponent<Image> ().color = new Color (0, 0, 0, alpha);
			if (alpha > 1.0f) {
				SceneManager.LoadScene ("Mainscene");
			}
		}

		previousText = outputText.text;
	}
}
