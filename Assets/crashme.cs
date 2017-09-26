using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crashme : MonoBehaviour {

    

    void Start()
    {
        //GetComponent<AudioSource>().clip = crash;

    }

	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
