using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchButtonChangeSceneScriptStart : MonoBehaviour {

	float alpha =0.0f;
	bool alphaTrigger = false;
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
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast(ray, out hit)) {
				if(hit.collider.gameObject.name == "StartButton"){
					alphaTrigger = true;
				}
			}
		}
		if (alphaTrigger) {
			alpha += 0.03f;
			this.GetComponent<Image> ().color = new Color (0, 0, 0, alpha);
		}
		if (alpha > 1.0f) {
			SceneManager.LoadScene ("Mainscene");
		}
	}
}
