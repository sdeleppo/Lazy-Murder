using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour
{

    //Handing
    public string menuName;
    public GameObject highscore;
    public GameObject hud;
    //Internal
    bool paused;
    Animator anim;

    int hasPlayed = 0; // variable inside the class, but not inside a function.
    void Start()
    {
        anim = GetComponent<Animator>();
        

        hasPlayed = PlayerPrefs.GetInt("HasPlayed");
        //PlayerPrefs.SetInt("HasPlayed", 0);
        if (hasPlayed == 0) // remember "==" for comparing, not "=" which assigns value
     {
         Pause();
         PlayerPrefs.SetInt("HasPlayed", 1);
     }
     else
     { 
        //Do lots of game save loading
     
     }
    }


    public void Pause()
    {
        paused = !paused;

        if (paused) { anim.SetBool("Show", true); }
        if (!paused) { anim.SetBool("Show", false); }

    }
   

    public void SetTime(float scale)
    {
        if (paused) { Time.timeScale = 0; }
        if (!paused) { Time.timeScale = 1; }
    }

    public void ResumeGame()
    {
        paused = false;
        anim.SetBool("Show", false);
    }


}
