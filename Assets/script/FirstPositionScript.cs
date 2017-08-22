using UnityEngine;
using System.Collections;

public class FirstPositionScript : MonoBehaviour {
	void Start(){
		Vector3 pos = this.transform.position;
		pos = new Vector3 (Random.Range(-7.0f, 7.0f), this.transform.position.y, Random.Range(-7.0f, 7.0f));

		this.transform.position = pos;
	}

	void Update(){
		
	}
}