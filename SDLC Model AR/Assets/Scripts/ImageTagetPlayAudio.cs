using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTagetPlayAudio : MonoBehaviour, ITrackableEventHandler
 {
    static int c = 0;
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject[] obj;

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (c < 1)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                // Play audio when target is found
                GetComponent<AudioSource>().Play();
                foreach(GameObject o in obj)
                {
                    o.SetActive(true);
                }
                c += 1;

            }
            else
            {
                // Stop audio when target is lost
                //audio.Stop();
            }
        }
    }

    // Use this for initialization
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
