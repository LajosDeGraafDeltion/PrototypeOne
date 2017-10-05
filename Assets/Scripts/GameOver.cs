using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public CarMovement carMovement;
    public GameObject gameOver;
    public GameObject player;
    public GameObject crashedCar;
    public Camera cam2;

    void Start ()
    {
        gameOver.SetActive(false);
        cam2.enabled = false;
    }
	
	void Update ()
    {
		if (carMovement.currentHealth <= 0)
        {
            CarCrashed();

        }
	}

    void CarCrashed()
    {
        player.SetActive(false);
        gameOver.SetActive(true);
        cam2.enabled = true;
        crashedCar.transform.Rotate(0, 0, 2);
    }
}
