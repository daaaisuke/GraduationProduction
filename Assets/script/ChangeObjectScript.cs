 using UnityEngine;
using System.Collections;

public class ChangeObjectScript : MonoBehaviour {

	private GameObject player;
	private GameObject dammy;
	public GameObject watermelon;
	public GameObject watermelon_right;
	public GameObject watermelon_left;
	private Vector3 watermelon_position;
	private Quaternion watermelon_rotation;
	public bool divideWaterMelon = false;

	void Start () {
		player = GameObject.Find("unitychan");
		dammy = GameObject.Find ("watermelon_dammy");
		watermelon = GameObject.Find ("watermelon_dammy").transform.FindChild("Watermelon").gameObject;
	}

//	void OnCollisionEnter(Collision col){
//		Debug.Log (col.gameObject.name);
//		if (col.gameObject.name == "stick") {
//			Debug.Log ("成功2");
//			if (divideWaterMelon == false) {
//				/*この中の処理を変えるだけ*/
//				watermelon_position = watermelon.transform.position;
//				watermelon_rotation = watermelon.transform.rotation;
//				Vector3 watermelon_position_copy = watermelon_position;
//				Quaternion watermelon_rotation_copy = watermelon_rotation;
//				Debug.Log (watermelon_position_copy);
//				Debug.Log (watermelon_rotation_copy);
//				Destroy (watermelon);
//				Instantiate (watermelon_left, watermelon_position_copy, watermelon_rotation_copy);
//				Instantiate (watermelon_right, watermelon_position_copy, watermelon_rotation_copy);
//				divideWaterMelon = true;
//				/*①unityちゃんとwatermelonのposition.xzを取得/角度計算/割れ目持って来る
//				  ②*/
//			}
//		}
//	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "stick") {
			if (divideWaterMelon == false) {
				/*この中の処理を変えるだけ*/
				watermelon_position = watermelon.transform.position;
				watermelon_rotation = watermelon.transform.rotation;
				Vector3 watermelon_position_copy = watermelon_position;
				Quaternion watermelon_rotation_copy = watermelon_rotation;
				float angle = GetAngle (player, watermelon) + 165.0f;
				Destroy (watermelon);
				Instantiate (watermelon_left, watermelon_position_copy + new Vector3(0.0f,0.0f,0.0f), watermelon_rotation_copy);
				GameObject.Find ("Watermelon_left (Clone)").transform.rotation = Quaternion.Euler (-90, angle, 0);
				Instantiate (watermelon_right, watermelon_position_copy, watermelon_rotation_copy);
				GameObject.Find ("Watermelon_right(Clone)").transform.rotation = Quaternion.Euler (90, angle, 0);
				divideWaterMelon = true;
				/*①unityちゃんとwatermelonのposition.xzを取得/角度計算/割れ目持って来る
				  ②*/
			}
		}
	}

	float GetAngle(GameObject obj1 ,GameObject obj2){
		Vector3 pos1 = obj1.transform.position;
		Vector3 pos2 = obj2.transform.position;

		float dx = pos1.x - pos2.x;
		float dy = pos1.y - pos2.y;
		float rad = Mathf.Atan2(dy, dx);
		return rad * Mathf.Rad2Deg;
	}
}