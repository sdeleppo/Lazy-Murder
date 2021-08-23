using UnityEngine;
using System.Collections;

public class GravityBody : MonoBehaviour {
	PlanetGravity planet;
	// Use this for initialization
	void Awake () {
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<PlanetGravity>();
		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		planet.Attract(transform);
	}
}
