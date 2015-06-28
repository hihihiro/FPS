using UnityEngine;
using System.Collections;

public class enemyspawner : MonoBehaviour {

	GameObject enemy;
	float timer;
	// Use this for initialization
	void Start () {
		timer = 5f;
		enemy = Resources.Load ("Enemy") as GameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) {
			timer = 5;
			Instantiate (enemy,transform.position,Quaternion.identity);
		}
	
	}
}
