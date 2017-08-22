using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchButtonChangeSceneScriptMain1 : MonoBehaviour {

	float alpha =0.0f;
	bool alphaTrigger = true;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//		if (Input.touchCount > 0) {
		//			//タッチ入力をRayに変更
		//			Ray ray = Camera.main.ScreenPointToRay (Input.touches [0].position);
		//			RaycastHit hit = new RaycastHit ();
		//			if(/*RayがStartに当たったら*/Physics.Raycast(ray, out hit)){
		//				if (hit.collider.gameObject.name == "Start") {
		//					Debug.Log ("成功");
		//				}
		//			}
		//		}
		//	}
		if (alphaTrigger) {
			alpha += 0.02f;
			this.GetComponent<Image> ().color = new Color (0, 0, 0, 1.0f - alpha);
			if (alpha > 1.0f) {
				alphaTrigger = false;
			}
		}
	}
}
