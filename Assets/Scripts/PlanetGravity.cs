using UnityEngine;
using System.Collections;

public class PlanetGravity : MonoBehaviour {
	public float gravity = -10f;
	// Use this for initialization
	public void Attract (Transform body) {
		Vector3 targetDir = (body.position - transform.position).normalized;
		Vector3 bodyUp = body.up;

		body.rotation = Quaternion.FromToRotation(bodyUp, targetDir) * body.rotation;
		body.GetComponent<Rigidbody>().AddForce(targetDir * gravity);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
}
