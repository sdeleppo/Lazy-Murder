using UnityEngine;
using System.Collections;

public class Ads : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        AdBuddizBinding.SetAndroidPublisherKey("311f48f9-7a75-4b0f-8900-85d8f1a4a6b0");

        AdBuddizBinding.CacheAds();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
