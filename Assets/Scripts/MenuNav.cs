using UnityEngine;
using System.Collections;

public class MenuNav : MonoBehaviour
{
    bool instructions;
    bool about;
    public Animator anim;
    public Animator anim1;
    GameObject deletes;
    // Use this for initialization
    void Start()
    {
        
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score = 0;
        deletes = GameObject.FindGameObjectWithTag("ScoreControl");
        Destroy(deletes);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Instructions()
    {
        anim.SetBool("Show", true);
    }
    public void About()
    {
        anim.SetBool("Show", true);
    }
    public void Credits()
    {
        anim1.SetBool("Show", true);
    }
    public void Exit()
    {
        anim.SetBool("Show", false);
        anim1.SetBool("Show", false);

    }
    public void Play()
    {
        Application.LoadLevel(1);
    }
    public void Leaderboards()
    {
        Application.LoadLevel(2);
    }

}