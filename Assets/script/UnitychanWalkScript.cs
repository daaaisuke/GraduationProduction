 using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnitychanWalkScript : MonoBehaviour {

	public GameObject output;

	private int changefalse = 0;
	private int changetrue = 0;
	private bool switchposvalue = true;
	private int changetextright = 0;
	private int changetextrightlittle = 0;
	private int changetextleft = 0;
	private int changetextleftlittle = 0;
	private bool changetexthit = false;
	private int changetextturn= 0;

	private Animator anim;
	private AnimatorStateInfo animStateInfo;

	private float alpha =0.0f;
	private bool alphaTrigger = false;


	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		Text outputText = output.GetComponent<Text>();
		if (changetexthit == false) {
			Debug.Log (outputText.text);
			//ただの右
			if (outputText.text.Contains ("右") && !outputText.text.Contains ("ちょっと") && !outputText.text.Contains ("少し")) {
				this.transform.Rotate (new Vector3 (0, 1, 0));
				changetextright += 1;
			}
			//少し右
			else if (outputText.text.Contains ("ちょっと") && outputText.text.Contains ("右")) {
				this.transform.Rotate (new Vector3 (0, 1, 0));
				changetextrightlittle += 1;
			}
			//ただの左
			else if (outputText.text.Contains ("左") && !outputText.text.Contains ("ちょっと") && !outputText.text.Contains ("少し")) {
				this.transform.Rotate (new Vector3 (0, -1, 0));
				changetextleft += 1;
			}
			//ちょっと左
			else if (outputText.text.Contains ("ちょっと") && outputText.text.Contains ("左")) {
				this.transform.Rotate (new Vector3 (0, -1, 0));
				changetextleftlittle += 1;
			}
			else if (outputText.text.Contains ("回れ") || outputText.text.Contains ("反対") || outputText.text.Contains ("逆")) {
				this.transform.Rotate (new Vector3 (0, 2, 0));
				changetextturn += 1;
			}
			else if (outputText.text.Contains ("そこ") || outputText.text.Contains ("叩け") || outputText.text.Contains ("今")) {
				anim.SetTrigger ("isHit");
				changetexthit = true;
			}
			else {
				//==================================================================================
				float fps = 1f / Time.deltaTime / 700;
				Vector3 pos = this.transform.localPosition;
				if (switchposvalue) {
					pos += new Vector3 (fps, 0f, fps);
					this.transform.position += this.transform.TransformDirection (Vector3.forward) * fps;
					this.transform.Rotate (new Vector3 (0.0f, 0.5f, 0.0f));
					changefalse += 1;
					if (changefalse == 20) {
						int rand = Random.Range (1, 4);
						if (rand == 1) {
							switchposvalue = true;
						} else {
							switchposvalue = false;
						}
						changefalse = 0;
					}
				} else {
					pos += new Vector3 (-fps, 0f, fps);
					this.transform.position += this.transform.TransformDirection (Vector3.forward) * fps;
					this.transform.Rotate (new Vector3 (0.0f, -0.5f, 0.0f));
					changetrue += 1;
					if (changetrue == 20) {
						int rand = Random.Range (1, 4);
						if (rand == 1) {
							switchposvalue = false;
						} else {
							switchposvalue = true;
						}
						changetrue = 0;
					}
				}
//				==================================================================================

			}
			if (changetextright == 30 || changetextrightlittle == 15 || changetextleft == 30 || changetextleftlittle == 15 || changetexthit == true || changetextturn == 90) {
				outputText.text = "";
				changetextright = 0;
				changetextrightlittle = 0;
				changetextleft = 0;
				changetextleftlittle = 0;
				changetextturn = 0;
			}
		}
		if (changetexthit == true) {
			animStateInfo = anim.GetCurrentAnimatorStateInfo(0);
			if (animStateInfo.fullPathHash == 1432961145) {
				if (animStateInfo.normalizedTime > 0.05) {
					alphaTrigger = true;
				}
			}
		}
		if (alphaTrigger) {
			alpha += 0.02f;
			GameObject.Find("Fade").GetComponent<Image> ().color = new Color (0, 0, 0, alpha);
		}
		if (alpha > 1.0f) {
			if (GameObject.Find("watermelon_dammy").GetComponent<ChangeObjectScript>().divideWaterMelon) {
				SceneManager.LoadScene ("Successscene");
			} else {
				SceneManager.LoadScene ("Failurescene");
			}
		}
	}
}
//Random.Range(-0.1f,0.1f)