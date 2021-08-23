using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour
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
        

       
    }

    /*void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            paused = !paused;

            if (paused) { anim.SetBool("Show", true); }
            if (!paused) { anim.SetBool("Show", false); }
        }
    }*/
    public void Pause()
    {
        paused = !paused;

        if (paused) { anim.SetBool("Show", true); }
        if (!paused) { anim.SetBool("Show", false); }

    }
    public void ShowHighScore()
    {
        Time.timeScale = 1;
        Application.LoadLevel(2);

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

    public void Restart()
    {
        paused = false;
        GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score = 0;
        Application.LoadLevel(Application.loadedLevel);
    }
}
