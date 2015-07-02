using UnityEngine;
using System.Collections;

//using UnityEngine.UI;
public class playerHP : MonoBehaviour {

	//public CanvasRenderer owari;
	//public int playernoHP;
	public GameObject hpbar;
	// Use this for initialization
	void Start () {
		//playernoHP = 50;
		//owari = Canvas.Gameover;
	
	}
	
	// Update is called once per frame
	void Update () {





	
	}
	 private void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Enemy") {
			//playernoHP --;

			Debug.Log("playernoHP");
			hpbar.gameObject.SendMessage("aDamage");
			//if (playernoHP == 0){
				//owari.GetComponent<Text> ().enabled = true;
		    //}
		}

	}
}//void OnTriggerEnter(Collider col){
//	if (col.GetComponent<Collider> ().gameObject.name == "Cube") {