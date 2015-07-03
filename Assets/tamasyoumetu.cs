using UnityEngine;
using System.Collections;

public class tamasyoumetu : MonoBehaviour {

	public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 //OnTriggerEnter(Collider col){
		//	if (col.GetComponent<Collider> ().gameObject) {
			//	Destroy(this.gameObject);
				
			//}

		//}
	
	}
	void OnTriggerEnter(Collider other) {
			Destroy(this.gameObject);
			Instantiate(explosion,transform.position,Quaternion.identity);
	}


	
}
