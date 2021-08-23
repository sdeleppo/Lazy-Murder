using UnityEngine;
using System.Collections;

public class LSpawn : MonoBehaviour {
    LeafSpawn spawner;
    public bool l1;
    public bool l2;
    public bool l3;
    public bool l4;
    public bool l5;
    public bool l6;
    public bool l7;
    public bool l8;
    public bool l9;
    public bool l10;
    public AudioSource crunch;
	// Use this for initialization
	void Start () {
        spawner = GameObject.FindGameObjectWithTag("Spawn").GetComponent<LeafSpawn>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            crunch.Play();
            if (l1)
                spawner.h1 = false;
            if (l2)
                spawner.h2 = false;
            if (l3)
                spawner.h3 = false;
            if (l4)
                spawner.h4 = false;
            if (l5)
                spawner.h5 = false;
            if (l6)
                spawner.h6 = false;
            if (l7)
                spawner.h7 = false;
            if (l8)
                spawner.h8 = false;
            if (l9)
                spawner.h9 = false;
            if (l10)
                spawner.h10 = false;

        }
	}
}
