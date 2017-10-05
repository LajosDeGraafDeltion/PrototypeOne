using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public int value;

	void Start ()
    {
		
	}
	

	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider cointrigger)
    {
        if (cointrigger.collider.tag  = "coin")
        {

        }
    }
}
