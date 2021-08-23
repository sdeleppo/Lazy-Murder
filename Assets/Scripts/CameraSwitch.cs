using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour
{

    //Handling
    public Transform main;
   
   public Transform cam;
    public GameObject human;
    public GameObject human1;
    public GameObject human2;
    public GameObject human3;
    public GameObject human4;
    public GameObject human5;
    public GameObject human6;
    public GameObject human7;
    public GameObject human8;
    public GameObject human9;
    //Internal
    public Transform goal;
    public float countdown = 5;
    public bool onHuman = false;
     public GameObject controller;
     public Transform target;
     int layerMask = 1 << 8;

     float dist;
     public GameObject touch;
     public AttackEnemy healthScript;
     public AttackEnemy healthScript1;
     public AttackEnemy healthScript2;
     public AttackEnemy healthScript3;
     public AttackEnemy healthScript4;
     public AttackEnemy healthScript5;
     public AttackEnemy healthScript6;
     public AttackEnemy healthScript7;
     public AttackEnemy healthScript8;
     public AttackEnemy healthScript9;
     bool onH = false;
     bool h1;
     bool h2;
     bool h3;
     bool h4;
     bool h5;
     bool h6;
     bool h7;
     bool h8;
     bool h9;
     bool h10;
     public AudioSource scream;
     public AudioSource thump;
     ScoreperSec scoreScript;
     public GameObject slothBody;
     public Animator anim;
     public Animator anim1;
     public Animator anim2;
     public Animator anim3;
     public Animator anim4;
     public Animator anim5;
     public Animator anim6;
     public Animator anim7;
     public Animator anim8;
     public Animator anim9;
     public GameObject claw;
     public GameObject claw1;
     public GameObject claw2;
     public GameObject claw3;
     public GameObject claw4;
     public GameObject claw5;
     public GameObject claw6;
     public GameObject claw7;
     public GameObject claw8;
     public GameObject claw9;
    void Start()
    {

        controller = GameObject.FindWithTag("Control");

        Time.timeScale = 1.0f;
        goal = main;
        scoreScript = GameObject.FindWithTag("Score").GetComponent<ScoreperSec>();

    }

    public void GoToMain()
    {
        goal = main;
    }

    public void GoToAbout()
    {
        
        onHuman = true;
        anim.SetBool("attacked", true);
        onH = true;
        healthScript.enabled = true;
        print("hi");
        h1 = true;
        goal = human.transform;
    }

    public void GoToHuman1()
    {
        //touch.SetActive(true);
        onH = true;
        anim1.SetBool("attacked", true);
        onHuman = true;
        goal = human1.transform;
        healthScript1.enabled = true;
        h2 = true;
    }
    public void GoToHuman2()
    {
        //touch.SetActive(true);
        onH = true;
        anim2.SetBool("attacked", true);
        onHuman = true;
        goal = human2.transform;
        healthScript2.enabled = true;
        h3 = true;
    }
    public void GoToHuman3()
    {
        //touch.SetActive(true);
        onH = true;
        anim3.SetBool("attacked", true);
        onHuman = true;
        goal = human3.transform;
        healthScript3.enabled = true;
        h4 = true;
    }
    public void GoToHuman4()
    {
        //touch.SetActive(true);
        onH = true;
        anim4.SetBool("attacked", true);
        onHuman = true;
        goal = human4.transform;
        healthScript4.enabled = true;
        h5 = true;
    }
    public void GoToHuman5()
    {
        //touch.SetActive(true);
        onH = true;
        anim5.SetBool("attacked", true);
        onHuman = true;
        goal = human5.transform;
        healthScript5.enabled = true;
        h6 = true;
    }
    public void GoToHuman6()
    {
        //touch.SetActive(true);
        onH = true;
        anim6.SetBool("attacked", true);
        onHuman = true;
        goal = human6.transform;
        healthScript6.enabled = true;
        h7 = true;
    }
    public void GoToHuman7()
    {
        //touch.SetActive(true);
        onH = true;
        anim7.SetBool("attacked", true);
        onHuman = true;
        goal = human7.transform;
        healthScript7.enabled = true;
        h8 = true;
    }
    public void GoToHuman8()
    {
        //touch.SetActive(true);
        onH = true;
        anim8.SetBool("attacked", true);
        onHuman = true;
        goal = human8.transform;
        healthScript8.enabled = true;
        h9 = true;
    }
    public void GoToHuman9()
    {
        //touch.SetActive(true);
        onH = true;
        anim9.SetBool("attacked", true);
        onHuman = true;
        goal = human9.transform;
        healthScript9.enabled = true;
        h10 = true;
    }
    void Raycast()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            bool isHit;
            isHit = false;

        }

        if (hit.collider != null && hit.collider.tag == "Human" && onH == false || dist <= 1 && onH == false)
            {
                touch.SetActive(true);
                GoToAbout();

                print("CLICCKKKK");

                print("click");

            scream.Play();
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);



            }
         else if (hit.collider != null && hit.collider.tag == "Human1" && onH == false || dist <= 1 && onH == false)
            {

                touch.SetActive(true);
                GoToHuman1();
                scream.Play();
                print("CLICCKKKK");

                print("click");


                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);



            }
            //meep
        else if (hit.collider != null && hit.collider.tag == "Human2" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman2();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human3" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman3();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human4" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman4();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human5" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman5();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human6" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman6();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human7" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman7();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human8" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman8();
            scream.Play();
        }
        else if (hit.collider != null && hit.collider.tag == "Human9" && onH == false || dist <= 1 && onH == false)
        {

            touch.SetActive(true);
            GoToHuman9();
            scream.Play();
        }
        
        }


    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("Human").Length != 0){
               healthScript = GameObject.FindGameObjectWithTag("Human").GetComponent<AttackEnemy>();
               anim = GameObject.FindGameObjectWithTag("anim").GetComponent<Animator>();
            }
        if (GameObject.FindGameObjectsWithTag("Human1").Length != 0)
        {
            healthScript1 = GameObject.FindGameObjectWithTag("Human1").GetComponent<AttackEnemy>();
            anim1 = GameObject.FindGameObjectWithTag("anim1").GetComponent<Animator>();
        }
        //meep
        if (GameObject.FindGameObjectsWithTag("Human2").Length != 0) { 
             healthScript2 = GameObject.FindGameObjectWithTag("Human2").GetComponent<AttackEnemy>();
             anim2 = GameObject.FindGameObjectWithTag("anim2").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human3").Length != 0) { 
             healthScript3 = GameObject.FindGameObjectWithTag("Human3").GetComponent<AttackEnemy>();
             anim3 = GameObject.FindGameObjectWithTag("anim3").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human4").Length != 0) { 
             healthScript4 = GameObject.FindGameObjectWithTag("Human4").GetComponent<AttackEnemy>();
             anim4 = GameObject.FindGameObjectWithTag("anim4").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human5").Length != 0) { 
             healthScript5 = GameObject.FindGameObjectWithTag("Human5").GetComponent<AttackEnemy>();
             anim5 = GameObject.FindGameObjectWithTag("anim5").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human6").Length != 0) { 
             healthScript6 = GameObject.FindGameObjectWithTag("Human6").GetComponent<AttackEnemy>();
             anim6 = GameObject.FindGameObjectWithTag("anim6").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human7").Length != 0) { 
             healthScript7 = GameObject.FindGameObjectWithTag("Human7").GetComponent<AttackEnemy>();
             anim7 = GameObject.FindGameObjectWithTag("anim7").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human8").Length != 0) { 
             healthScript8 = GameObject.FindGameObjectWithTag("Human8").GetComponent<AttackEnemy>();
             anim8 = GameObject.FindGameObjectWithTag("anim8").GetComponent<Animator>();
        }
        if (GameObject.FindGameObjectsWithTag("Human9").Length != 0) { 
             healthScript9 = GameObject.FindGameObjectWithTag("Human9").GetComponent<AttackEnemy>();
             anim9 = GameObject.FindGameObjectWithTag("anim9").GetComponent<Animator>();
        }
        //print(anim.GetBool("attack"));
        dist = Vector3.Distance(controller.transform.position, transform.position);
        if (Input.GetMouseButtonDown(0))
        {
            Raycast();

        }

        

        
         else if (onHuman)
        {
            
            onH = true;
            controller.GetComponent<FirstPersonController>().enabled = false;
            cam.GetComponent<SmoothFollow>().enabled = false;
            slothBody.SetActive(false);
            cam.localPosition = Vector3.MoveTowards(cam.localPosition, goal.localPosition, Time.deltaTime * 20f);
            cam.transform.localRotation = goal.transform.localRotation;

            //touch.SetActive(true);
            
            countdown -= Time.deltaTime;
            print(countdown);
            if (countdown <= 0 || healthScript.enemyHealth <= 0 || healthScript1.enemyHealth1 <= 0 || healthScript2.enemyHealth2 <= 0 || healthScript3.enemyHealth3 <= 0
                || healthScript4.enemyHealth4 <= 0 || healthScript5.enemyHealth5 <= 0 || healthScript6.enemyHealth6 <= 0 || healthScript7.enemyHealth7 <= 0 || healthScript8.enemyHealth8 <= 0 || healthScript9.enemyHealth9 <= 0)
            {
                
                Debug.Log("main");
                goal = main.transform;
                controller.GetComponent<FirstPersonController>().enabled = true;
                cam.GetComponent<SmoothFollow>().enabled = true;
                slothBody.SetActive(true);
                
                if (countdown <= 0)
                {
                    if (h1)
                    {
                        anim.SetBool("attacked", false);
                        claw.SetActive(false);
                    }
                    if (h2)
                    {
                        anim1.SetBool("attacked", false);
                        claw1.SetActive(false);
                    }
                    if (h3)
                    {
                        anim2.SetBool("attacked", false);
                        claw2.SetActive(false);
                    }
                    if (h4)
                    {
                        anim3.SetBool("attacked", false);
                        claw3.SetActive(false);
                    }
                    if (h5)
                    {
                        anim4.SetBool("attacked", false);
                        claw4.SetActive(false);
                    }
                    if (h6)
                    {
                        anim5.SetBool("attacked", false);
                        claw5.SetActive(false);
                    }
                    if (h7)
                    {
                        anim6.SetBool("attacked", false);
                        claw6.SetActive(false);
                    }
                    if (h8)
                    {
                        anim7.SetBool("attacked", false);
                        claw7.SetActive(false);
                    }
                    if (h9)
                    {
                        anim8.SetBool("attacked", false);
                        claw8.SetActive(false);
                    }
                    if (h10)
                    {
                        anim9.SetBool("attacked", false);
                        claw9.SetActive(false);
                    }
                    //anim.SetBool("attacked", false);
                    //anim2.SetBool("attacked", false);
                    //anim3.SetBool("attacked", false);
                    //anim4.SetBool("attacked", false);
                    //anim5.SetBool("attacked", false);
                    //anim6.SetBool("attacked", false);
                    //anim7.SetBool("attacked", false);
                    //anim8.SetBool("attacked", false);
                    //anim9.SetBool("attacked", false);
                    //anim1.SetBool("attacked", false);
                    //claw.SetActive(false);
                    //claw1.SetActive(false);
                    //claw2.SetActive(false);
                    //claw3.SetActive(false);
                    //claw4.SetActive(false);
                    //claw5.SetActive(false);
                    //claw6.SetActive(false);
                    //claw7.SetActive(false);
                    //claw8.SetActive(false);
                    //claw9.SetActive(false);
                }
                countdown = 5;
                if (healthScript.enemyHealth <= 0 && h1)
                {
                    anim.SetBool("dead", true);
                    print("dead");
                    
                    claw.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim").GetComponent<BloodDestroy>().enabled = true;
                    Destroy(GameObject.FindGameObjectWithTag("Human"));
                    healthScript1.enemyHealth1 = 7;
                    healthScript.enemyHealth = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (healthScript1.enemyHealth1 <= 0 && h2)
                {
                    anim1.SetBool("dead", true);
                    claw1.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim1").GetComponent<BloodDestroy>().enabled = true;
                    Destroy(GameObject.FindGameObjectWithTag("Human1"));
                    healthScript.enemyHealth = 7;
                    healthScript1.enemyHealth1 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (healthScript2.enemyHealth2 <= 0 && h3)
                {
                    anim2.SetBool("dead", true);
                    claw2.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim2").GetComponent<BloodDestroy>().enabled = true;
                    print("dead");
                    Destroy(GameObject.FindGameObjectWithTag("Human2"));
                    healthScript2.enemyHealth2 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();

                }
                if (healthScript3.enemyHealth3 <= 0 && h4)
                {
                    anim3.SetBool("dead", true);
                    claw3.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim3").GetComponent<BloodDestroy>().enabled = true;
                    Destroy(GameObject.FindGameObjectWithTag("Human3"));
                    healthScript3.enemyHealth3 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();

                } if (healthScript4.enemyHealth4 <= 0 && h5)
                {
                    anim4.SetBool("dead", true);
                    claw4.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim4").GetComponent<BloodDestroy>().enabled = true;
                    print("dead");
                    Destroy(GameObject.FindGameObjectWithTag("Human4"));
                    healthScript4.enemyHealth4 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (healthScript5.enemyHealth5 <= 0 && h6)
                {
                    anim5.SetBool("dead", true);
                    claw5.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim5").GetComponent<BloodDestroy>().enabled = true;
                    Destroy(GameObject.FindGameObjectWithTag("Human5"));
                    healthScript5.enemyHealth5 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                } if (healthScript6.enemyHealth6 <= 0 && h7)
                {
                    anim6.SetBool("dead", true);
                    claw6.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim6").GetComponent<BloodDestroy>().enabled = true;
                    print("dead");
                    Destroy(GameObject.FindGameObjectWithTag("Human6"));
                    healthScript6.enemyHealth6 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (healthScript7.enemyHealth7 <= 0 && h8)
                {
                    anim7.SetBool("dead", true);
                    claw7.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim7").GetComponent<BloodDestroy>().enabled = true;
                    Destroy(GameObject.FindGameObjectWithTag("Human7"));
                    healthScript7.enemyHealth7 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (healthScript8.enemyHealth8 <= 0 && h9)
                {
                    anim8.SetBool("dead", true);
                    claw8.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim8").GetComponent<BloodDestroy>().enabled = true;
                    print("dead");
                    Destroy(GameObject.FindGameObjectWithTag("Human8"));
                    healthScript8.enemyHealth8 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (healthScript9.enemyHealth9 <= 0 && h10)
                {
                    anim9.SetBool("dead", true);
                    claw9.SetActive(false);
                    GameObject.FindGameObjectWithTag("anim9").GetComponent<BloodDestroy>().enabled = true;
                    Destroy(GameObject.FindGameObjectWithTag("Human9"));
                    healthScript9.enemyHealth9 = 7;
                    GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 500;
                    scoreScript.score += 500;
                    thump.Play();
                }
                if (h1)
                {
                    h1 = false;
                    
                    healthScript.enabled = false;

                }
                 if (h2)
                {
                    h2 = false;
                    healthScript1.enabled = false;
                    
                }
                 if (h3)
                 {
                     h3 = false;

                     healthScript2.enabled = false;

                 }
                 if (h4)
                 {
                     h4 = false;
                     healthScript3.enabled = false;

                 }
                 if (h5)
                 {
                     h5 = false;

                     healthScript4.enabled = false;

                 }
                 if (h6)
                 {
                     h6 = false;
                     healthScript5.enabled = false;

                 }
                 if (h7)
                 {
                     h7 = false;

                     healthScript6.enabled = false;

                 }
                 if (h8)
                 {
                     h8 = false;
                     healthScript7.enabled = false;

                 }
                 if (h9)
                 {
                     h9 = false;

                     healthScript8.enabled = false;

                 }
                 if (h10)
                 {
                     h10 = false;
                     healthScript9.enabled = false;

                 }
                
                touch.SetActive(false);
                onH = false;
                onHuman = false;

                
            }
        }

            

    }
}



