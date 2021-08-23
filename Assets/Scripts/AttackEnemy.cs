using UnityEngine;
using System.Collections;

public class AttackEnemy : MonoBehaviour {
    public int enemyHealth = 7;
    public int enemyHealth1 = 7;
    public int enemyHealth2 = 7;
    public int enemyHealth3 = 7;
    public int enemyHealth4 = 7;
    public int enemyHealth5 = 7;
    public int enemyHealth6 = 7;
    public int enemyHealth7 = 7;
    public int enemyHealth8 = 7;
    public int enemyHealth9 = 7;
    public ParticleSystem blood;
   // CameraSwitch camS;
    //bool human;
    //bool human1;
    //bool human2;
    //bool human3;
    //bool human4;
    //bool human5;
    //bool human6;
    //bool human7;
    //bool human8;
    //bool human9;
	// Use this for initialization
	void Start () {
       // camS = this.gameObject.GetComponent<CameraSwitch>();
        enemyHealth = 7;
        enemyHealth1 = 7;
        enemyHealth2 = 7;
        enemyHealth3 = 7;
        enemyHealth4 = 7;
        enemyHealth5 = 7;
        enemyHealth6 = 7;
        enemyHealth7 = 7;
        enemyHealth8 = 7;
        enemyHealth9 = 7;

	}
	
	// Update is called once per frame
	public void OnDamage (int damage) {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth--;

	}
    public void OnDamage1(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth1--;

    }
    public void OnDamage2(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth2--;

    }
    public void OnDamage3(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth3--;

    }
    public void OnDamage4(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth4--;

    }
    public void OnDamage5(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth5--;

    }
    public void OnDamage6(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth6--;

    }
    public void OnDamage7(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth7--;

    }
    public void OnDamage8(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth8--;

    }
    public void OnDamage9(int damage)
    {
        Instantiate(blood, transform.position, transform.rotation);
        enemyHealth9--;

    }
    void Update()
    {
        print(enemyHealth1);
       //if (enemyHealth <= 0){
       //     camS.healthScript.enabled = false;
       //     camS.touch.enabled = false;
       //     Debug.Log("main");
       //     camS.goal = camS.main.transform;
       //     camS.controller.GetComponent<FirstPersonController>().enabled = true;
       //     camS.cam.GetComponent<SmoothFollow>().enabled = true;
       //     camS.countdown = 5;
       //     camS.onHuman = false;
       //     enemyHealth = 7;
       //     Destroy(gameObject);
       //}
    }
}
