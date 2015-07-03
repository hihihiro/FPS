using UnityEngine;
using System.Collections;

public class Na : MonoBehaviour {

	int enemyHP;
	GameObject effect;
	
	GameObject target;
	NavMeshAgent agent;
	float i = 0.22f;
	//public GameObject kouka;
	GameObject hajike;
	
	// Use this for initialization
	void Start () {
		enemyHP = 3;
		effect = Resources.Load ("Detonator-Simple") as GameObject;
		
		target = GameObject.FindWithTag("Player");
		agent = GetComponent<NavMeshAgent> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.transform.position);
		
		
	}
	public void Damage() {
		enemyHP--;
		transform.localScale += new Vector3 (i, i, i);
		
		if (enemyHP == 0) {
			Instantiate(effect,transform.position,Quaternion.identity);
			Destroy(this.gameObject);
			//kouka.gameObject.SendMessage("koukahatudou");
			Instantiate(hajike,transform.position,Quaternion.identity);
			//this.GetComponent<ParticleSystem>();
		}
	}
	
	void OnParticleCollision(GameObject obj){
		//if (col.gameObject.tag == "partical") {
		Destroy (this.gameObject);
		//}
	}
	
	//public void Damage1(){
	//	Destroy (this.gameObject);
	//}
	
	//if ()
}
