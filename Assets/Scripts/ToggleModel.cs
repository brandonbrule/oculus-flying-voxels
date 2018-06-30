using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleModel : MonoBehaviour {
    //public List<Models> modelsArray;
    private int index = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetUp(OVRInput.Button.One))

        {
            if(index < transform.childCount - 1 )
            {
                index = index + 1;
            }
            

            transform.GetChild(index - 1).gameObject.SetActive(false);
            transform.GetChild(index).gameObject.SetActive(true);
        }

        if (OVRInput.GetUp(OVRInput.Button.Two))

        {
            if (index > 0)
            {
                index = index - 1;
            }

            transform.GetChild(index + 1).gameObject.SetActive(false);
            transform.GetChild(index).gameObject.SetActive(true);
        }
    }
}
