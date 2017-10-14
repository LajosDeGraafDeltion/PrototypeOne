using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelAnimation : MonoBehaviour {

    public GameObject jerryCan;
    public CarMovement cMove;
    public float fuelAmount;

	void Start ()
    {
        
    }
	
	void Update ()
    {
        jerryCan.transform.Rotate(0, 0, 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cMove.currentFuel += fuelAmount;
        }
    }
}
