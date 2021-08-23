using UnityEngine;
using System.Collections;

public class TreeCollide : MonoBehaviour
{
    public AudioSource slothSqueak;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            slothSqueak.Play();

        }
    }

}
