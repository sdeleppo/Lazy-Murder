using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour
{

    // Use this for initialization
    //Boxes s;
    public int score = 0;
    void Awake()
    {

       // s = GameObject.FindGameObjectWithTag("score").GetComponent<Boxes>();
        //score = Boxes.score;
        print(score);
        DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print("SCORE YEEEE" + score);
    }
}
