﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public string scene_name;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetUp(OVRInput.Button.Three))

        {
            SceneManager.LoadScene(scene_name);
        }
    }
}
