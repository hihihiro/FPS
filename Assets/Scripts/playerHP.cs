using UnityEngine;
using System.Collections;

public class playerHP : MonoBehaviour {

	public int playernoHP;
	// Use this for initialization
	void Start () {
		playernoHP = 50;
	
	}
	
	// Update is called once per frame
	void Update () {





	
	}
	void OnTriggerEnter(Collider col){
		if (col.GetComponent<Collider> ().gameObject.name == "Cube") {
			playernoHP --;
			//if (playernoHP == 0){
			//	Instantiate();
		    //}
		}

	}
}