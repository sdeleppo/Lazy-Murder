using UnityEngine;
using System.Collections;

public class EatLeaf : MonoBehaviour
{
    public ParticleSystem leafCrunch;
    ScoreperSec scoreScript;
    
    // Use this for initialization
    void Start()
    {
        scoreScript = GameObject.FindWithTag("Score").GetComponent<ScoreperSec>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreScript.score += 100;
            GameObject.FindGameObjectWithTag("ScoreControl").GetComponent<ScoreControl>().score += 100;
            Instantiate(leafCrunch, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}