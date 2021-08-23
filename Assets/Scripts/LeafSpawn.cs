using UnityEngine;
using System.Collections;

public class LeafSpawn : MonoBehaviour {
    public GameObject leaf;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;
    public GameObject spawner7;
    public GameObject spawner8;
    public GameObject spawner9;
    public GameObject spawner10;
   public bool h1 = false;
   public bool h2 = false;
   public bool h3 = false;
   public bool h4 = false;
   public bool h5 = false;
   public bool h6 = false;
   public bool h7 = false;
   public bool h8 = false;
   public bool h9 = false;
   public bool h10 = false;
   float t1 = 0;
   float t2 = 0;
   float t3 = 0;
   float t4 = 0;
   float t5 = 0;
   float t6 = 0;
   float t7 = 0;
   float t8 = 0;
   float t9 = 0;
   float t10 = 0;
	// Use this for initialization

	void Update () {
        if (GameObject.FindGameObjectsWithTag("Leaf").Length != 10)
        {
            if (h1 == false)
                Spawn();
            if (h2 == false)
                Spawn1();
            if (h3 == false)
                Spawn2();
            if (h4 == false)
                Spawn3();
            if (h5 == false)
                Spawn4();
            if (h6 == false)
                Spawn5();
            if (h7 == false)
                Spawn6();
            if (h8 == false)
                Spawn7();
            if (h9 == false)
                Spawn8();
            if (h10 == false)
                Spawn9();
        }
	}
	
	// Update is called once per frame
	void Spawn () {
        spawner1.GetComponent<LSpawn>().enabled = false;
        t1 -= Time.deltaTime;
        if (t1 <= 0)
        {
            Instantiate(leaf, spawner1.transform.position, spawner1.transform.rotation);
            t1 = 20;
            spawner1.GetComponent<LSpawn>().enabled = true;
            h1 = true;
        }
	}
    void Spawn1 ()
    {
        spawner2.GetComponent<LSpawn>().enabled = false;
        t2 -= Time.deltaTime;
        if (t2 <= 0)
        {
            Instantiate(leaf, spawner2.transform.position, spawner2.transform.rotation);
            t2 = 20;
            spawner2.GetComponent<LSpawn>().enabled = true;
            h2 = true;
        }
    }
    void Spawn2()
    {
        spawner3.GetComponent<LSpawn>().enabled = false;
        t3 -= Time.deltaTime;
        if (t3 <= 0)
        {
            Instantiate(leaf, spawner3.transform.position, spawner3.transform.rotation);
            t3 = 20;
            spawner3.GetComponent<LSpawn>().enabled = true;
            h3 = true;
        }
    }
    void Spawn3()
    {
        spawner4.GetComponent<LSpawn>().enabled = false;
        t4 -= Time.deltaTime;
        if (t4 <= 0)
        {
            Instantiate(leaf, spawner4.transform.position, spawner4.transform.rotation);
            t4 = 20;
            spawner4.GetComponent<LSpawn>().enabled = true;
            h4 = true;
        }
    }
    void Spawn4()
    {
        spawner5.GetComponent<LSpawn>().enabled = false;
        t5 -= Time.deltaTime;
        if (t5 <= 0)
        {
            Instantiate(leaf, spawner5.transform.position, spawner5.transform.rotation);
            t5 = 20;
            spawner5.GetComponent<LSpawn>().enabled = true;
            h5 = true;
        }
    }
    void Spawn5()
    {
        spawner6.GetComponent<LSpawn>().enabled = false;
        t6 -= Time.deltaTime;
        if (t6 <= 0)
        {
            Instantiate(leaf, spawner6.transform.position, spawner6.transform.rotation);
            t6 = 20;
            spawner6.GetComponent<LSpawn>().enabled = true;
            h6 = true;
        }
    }
    void Spawn6()
    {
        spawner7.GetComponent<LSpawn>().enabled = false;
        t7 -= Time.deltaTime;
        if (t7 <= 0)
        {
            Instantiate(leaf, spawner7.transform.position, spawner7.transform.rotation);
            t7 = 20;
            spawner7.GetComponent<LSpawn>().enabled = true;
            h7 = true;
        }
    }
    void Spawn7()
    {
        spawner8.GetComponent<LSpawn>().enabled = false;
        t8 -= Time.deltaTime;
        if (t8 <= 0)
        {
            Instantiate(leaf, spawner8.transform.position, spawner8.transform.rotation);
            t8 = 20;
            spawner8.GetComponent<LSpawn>().enabled = true;
            h8 = true;
        }
    }
    void Spawn8()
    {
        spawner9.GetComponent<LSpawn>().enabled = false;
        t9 -= Time.deltaTime;
        if (t9 <= 0)
        {
            Instantiate(leaf, spawner9.transform.position, spawner9.transform.rotation);
            t9 = 20;
            spawner9.GetComponent<LSpawn>().enabled = true;
            h9 = true;
        }
    }
    void Spawn9()
    {
        spawner10.GetComponent<LSpawn>().enabled = false;
        t10 -= Time.deltaTime;
        if (t10 <= 0)
        {
            Instantiate(leaf, spawner10.transform.position, spawner10.transform.rotation);
            t10 = 20;
            spawner10.GetComponent<LSpawn>().enabled = true;
            h10 = true;
        }
    }
}
