using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchButtonChangeSceneScriptMain2: MonoBehaviour {

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
//		if(叩くアニメーションが実行されたら){
//			スイカが当たったかどうかの情報をほじ
//			インヴォークを使って時間を調節
//					alphaTrigger = true;
//		}
//		if (alphaTrigger) {
//			alpha += 0.01f;
//			this.GetComponent<Image> ().color = new Color (0, 0, 0, alpha);
//		}
//		if (alpha > 1.0f) {
//			if (スイカに棒が当たったら) {
//				SceneManager.LoadScene ("Successscene");
//			} else {
//			}
//			SceneManager.LoadScene ("Failurescene");
//		}
	}
}
