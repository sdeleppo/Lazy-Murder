using UnityEngine;
using System.Collections;

public class LeafRotate : MonoBehaviour {
    public float speed = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(  0, 0,speed * Time.deltaTime);
	}
}
