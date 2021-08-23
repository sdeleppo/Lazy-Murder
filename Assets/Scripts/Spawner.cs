using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
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
    public GameObject humanPre1;
    public GameObject humanPre2;
    public GameObject humanPre3;
    public GameObject humanPre4;
    public GameObject humanPre5;
    public GameObject humanPre6;
    public GameObject humanPre7;
    public GameObject humanPre8;
    public GameObject humanPre9;
    public GameObject humanPre10;
    public float spawnCount = 0f;
    public float spawnCount1 = 0f;
    public float spawnCount2 = 0f;
    public float spawnCount3 = 0f;
    public float spawnCount4 = 0f;
    public float spawnCount5 = 0f;
    public float spawnCount6 = 0f;
    public float spawnCount7 = 0f;
    public float spawnCount8 = 0f;
    public float spawnCount9 = 0f;
	// Use this for initialization
	void Update () {
	 if (GameObject.FindGameObjectsWithTag("Human").Length == 0)
        {

            Spawn();
        }
         if (GameObject.FindGameObjectsWithTag("Human1").Length == 0)
        {
            
                Spawn1();
        }
         if (GameObject.FindGameObjectsWithTag("Human2").Length == 0)
         {

             Spawn2();
         }
         if (GameObject.FindGameObjectsWithTag("Human3").Length == 0)
         {

             Spawn3();
         }
         if (GameObject.FindGameObjectsWithTag("Human4").Length == 0)
         {

             Spawn4();
         }
         if (GameObject.FindGameObjectsWithTag("Human5").Length == 0)
         {

             Spawn5();
         }
         if (GameObject.FindGameObjectsWithTag("Human6").Length == 0)
         {

             Spawn6();
         }
         if (GameObject.FindGameObjectsWithTag("Human7").Length == 0)
         {

             Spawn7();
         }
         if (GameObject.FindGameObjectsWithTag("Human8").Length == 0)
         {

             Spawn8();
         }
         if (GameObject.FindGameObjectsWithTag("Human9").Length == 0)
         {

             Spawn9();
         }
	}
   public void Spawn()
    {
        spawnCount -= Time.deltaTime;
        if (spawnCount <= 0)
        {
            Instantiate(humanPre1, spawner1.transform.position, spawner1.transform.rotation);
           spawnCount = 20f;
            this.GetComponent<CameraSwitch>().healthScript = GameObject.FindGameObjectWithTag("Human").GetComponent<AttackEnemy>();
        }
    }
	// Update is called once per frame
   public void Spawn1()
    {
       spawnCount1 -= Time.deltaTime;
        if (spawnCount1 <= 0)
        {
            Instantiate(humanPre2,spawner2.transform.position, spawner2.transform.rotation);
            spawnCount1 = 20f;
            this.GetComponent<CameraSwitch>().healthScript1 = GameObject.FindGameObjectWithTag("Human1").GetComponent<AttackEnemy>();
        }
    }
   public void Spawn2()
   {
       spawnCount2 -= Time.deltaTime;
       if (spawnCount2 <= 0)
       {
           Instantiate(humanPre3, spawner3.transform.position, spawner3.transform.rotation);
           spawnCount2 = 20f;
           this.GetComponent<CameraSwitch>().healthScript2 = GameObject.FindGameObjectWithTag("Human2").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn3()
   {
       spawnCount3 -= Time.deltaTime;
       if (spawnCount3 <= 0)
       {
           Instantiate(humanPre4, spawner4.transform.position, spawner4.transform.rotation);
           spawnCount3 = 20f;
           this.GetComponent<CameraSwitch>().healthScript3 = GameObject.FindGameObjectWithTag("Human3").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn4()
   {
       spawnCount4 -= Time.deltaTime;
       if (spawnCount4 <= 0)
       {
           Instantiate(humanPre5, spawner5.transform.position, spawner5.transform.rotation);
           spawnCount4 = 20f;
           this.GetComponent<CameraSwitch>().healthScript4 = GameObject.FindGameObjectWithTag("Human4").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn5()
   {
       spawnCount5 -= Time.deltaTime;
       if (spawnCount5 <= 0)
       {
           Instantiate(humanPre6, spawner6.transform.position, spawner6.transform.rotation);
           spawnCount5 = 20f;
           this.GetComponent<CameraSwitch>().healthScript5 = GameObject.FindGameObjectWithTag("Human5").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn6()
   {
       spawnCount6 -= Time.deltaTime;
       if (spawnCount6 <= 0)
       {
           Instantiate(humanPre7, spawner7.transform.position, spawner7.transform.rotation);
           spawnCount6 = 20f;
           this.GetComponent<CameraSwitch>().healthScript6 = GameObject.FindGameObjectWithTag("Human6").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn7()
   {
       spawnCount7 -= Time.deltaTime;
       if (spawnCount7 <= 0)
       {
           Instantiate(humanPre8, spawner8.transform.position, spawner8.transform.rotation);
           spawnCount7 = 20f;
           this.GetComponent<CameraSwitch>().healthScript7 = GameObject.FindGameObjectWithTag("Human7").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn8()
   {
       spawnCount8 -= Time.deltaTime;
       if (spawnCount8 <= 0)
       {
           Instantiate(humanPre9, spawner9.transform.position, spawner9.transform.rotation);
           spawnCount8 = 20f;
           this.GetComponent<CameraSwitch>().healthScript8 = GameObject.FindGameObjectWithTag("Human8").GetComponent<AttackEnemy>();
       }
   }
   public void Spawn9()
   {
       spawnCount9 -= Time.deltaTime;
       if (spawnCount9 <= 0)
       {
           Instantiate(humanPre10, spawner10.transform.position, spawner10.transform.rotation);
           spawnCount9 = 20f;
           this.GetComponent<CameraSwitch>().healthScript9 = GameObject.FindGameObjectWithTag("Human9").GetComponent<AttackEnemy>();
       }
   }
}
