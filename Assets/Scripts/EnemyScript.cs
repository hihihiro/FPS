using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	int enemyHP;
	GameObject effect;

	GameObject target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		enemyHP = 3;
		effect = Resources.Load ("Detonator-Simple")as GameObject;

		target = GameObject.FindWithTag("Player");
		agent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.transform.position);
	
	}
	public void Damage() {
		enemyHP--;
		if (enemyHP == 0) {
			Instantiate(effect,transform.position,Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
