using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubmitHighscore : MonoBehaviour
{

    public int score;//GET A REFERENCE OF THE PLAYER'S CURRENT SCORE HERE
    public InputField playerName;//THIS IS WHERE THEY ENTER THEIR NAME
    //Boxes s;
    GameObject deletes;


    public void SubmitScore()
    {
        score = GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score;

        if (playerName.text.Length > 0)
        {
            Highscores.AddNewHighScore(playerName.text, score);
            this.gameObject.SetActive(false);
        }
        GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score = 0;
        deletes = GameObject.FindGameObjectWithTag("ScoreControl");
        Destroy(deletes);
    }
}
