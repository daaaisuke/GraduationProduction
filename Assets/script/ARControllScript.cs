using UnityEngine;
using System.Collections;

public class ARControllScript : MonoBehaviour {

	private GameObject suika;
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		suika = GameObject.Find ("watermelon_dammy");
		unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.GetComponent<TerrainCollider> ().enabled) {
			suika.SetActive (true);
			unitychan.SetActive (true);
		} else {
			suika.SetActive (false);
			unitychan.SetActive (false);
		}
	
	}
}
