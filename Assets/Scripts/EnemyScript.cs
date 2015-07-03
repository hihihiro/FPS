using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	int enemyHP;
	GameObject effect;

	GameObject target;
	NavMeshAgent agent;
	float i = 0.22f;
	//public GameObject kouka;
	public GameObject hajike;
	//ParticleSystem _par = this.GetComponent<ParticleSystem>();
	// Use this for initialization
	void Start () {
		enemyHP = 3;
		effect = Resources.Load ("Detonator-Simple") as GameObject;

		target = GameObject.FindWithTag("Player");
		agent = GetComponent<NavMeshAgent> ();
		//this.GetComponent<Particle> ().Play ();
		//Particle.Play();
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
			this.GetComponent<ParticleSystem>();
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
