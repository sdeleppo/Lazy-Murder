using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreperSec : MonoBehaviour {
    public int score = 0;
    float countdown = 1f;
    public Text scoreText;
    bool mission;
	// Use this for initialization
	void Start () {
        mission = false;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            score += 10;
            GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 10;
            countdown += 1f;
        }
        //print(score);
        scoreText.text = "Score: " + score;
        if (score >= 1500 && mission == false)
        {

            GiftizBinding.missionComplete();
            mission = true;
            print("mission complete");

        }
	}
}
