using UnityEngine;
using System.Collections;

public class tamaparticle : MonoBehaviour
{
	void  OnParticleCollision (GameObject other)
	{
		ParticleSystem shuriken = other.GetComponent<ParticleSystem>();
		ParticleCollisionEvent[] ces = new ParticleCollisionEvent[shuriken.safeCollisionEventSize];
		int count = shuriken.GetCollisionEvents (gameObject, ces);
		foreach(ParticleCollisionEvent item in ces) {
			// action
			Debug.Log (item.collider);
		}
	}
}
