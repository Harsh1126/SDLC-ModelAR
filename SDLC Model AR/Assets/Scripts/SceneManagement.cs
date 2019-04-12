using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class SceneManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void waterModel()
    {
        SceneManager.LoadScene(1);
    }
    public void incModel()
    {
        SceneManager.LoadScene(2);
    }
    public void protyModel()
    {
        SceneManager.LoadScene(3);
    }
    public void spModel()
    {
        SceneManager.LoadScene(4);
    }
    public void radModel()
    {
        SceneManager.LoadScene(5);
    }
    public void agileModel()
    {
        SceneManager.LoadScene(6);
    }
}
