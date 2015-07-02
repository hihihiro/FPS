using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public AudioSource shotsound;//juu no oto
	GameObject hitsound; //juu ga atatta toki no nto

	// Use this for initialization
	void Start () {
		hitsound = Resources.Load ("Hitsound") as GameObject;
	
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Shot ();
		}
	
	}
	void Shot(){
		Ray ray;
		RaycastHit hit;
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		ray = Camera.main.ScreenPointToRay (center);
		shotsound.Play ();
		int distantce = 100;

		//if ()
			if (Physics.Raycast (ray, out hit, distantce)) {
				 if(hit.transform.gameObject.CompareTag ("Enemy")) {
					Instantiate(hitsound,hit.point,Quaternion.identity);
					hit.transform.gameObject.SendMessage("Damage");

			 }
		}
		Debug.DrawLine (ray.origin, ray.direction * distantce, Color.yellow);
	}


}
