using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
    public GameObject death;
    public GameObject pauseButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
        if (col.tag == "Trigger")
        {
            death.GetComponent<PauseManager>().Pause();
            pauseButton.SetActive(false);
            GameObject.FindGameObjectWithTag("Spawn").GetComponent<CameraSwitch>().enabled = false;
        }
	}
}
