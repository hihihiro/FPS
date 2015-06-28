using UnityEngine;
using System.Collections;

public class buki : MonoBehaviour {


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 3, 0));

	}
	void OnTriggerEnter (Collider col){
		if (col.GetComponent<Collider> ().gameObject.name == "FPSController"){
			//Debug.Log("hit");
			GetComponent<Renderer> ().enabled = false;         //buttai no tyekku wo hazusu
			Invoke ("aaa",20);
			hoge.SendMessage("bukichange");
		}
	}
	void aaa(){
		GetComponent<Renderer> ().enabled = true;
	}

}
