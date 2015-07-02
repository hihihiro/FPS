using UnityEngine;
using System.Collections;

public class bukisimau : MonoBehaviour {
	public GameObject taihou;
	//public GameObject bukiSpawner;
	public GameObject oya;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter(Collider col){
		if (col.GetComponent<Collider> ().gameObject.name == "Cube") {
			Destroy(this.gameObject);
			//Instantiate (taihou,bukiSpawner.transform.position,Quaternion.identity);
			GameObject kodomo = Instantiate(taihou) as GameObject;
			kodomo.transform.parent = oya.transform;
		}

	}

}