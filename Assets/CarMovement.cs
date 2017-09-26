using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    public float moveSpeed;
    public float rotSpeed;
    public float moveV;
    public float turnH;
    public float brakeSpeed;
    public float boostActive;

    public AudioClip horn;
    public AudioClip crash;

    void Start ()
    {
        GetComponents<AudioSource>()[1].clip = horn;
        GetComponents<AudioSource>()[0].clip = crash;

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponents<AudioSource>()[1].Play();
        }
    }

    void FixedUpdate ()
    {
        moveV = Input.GetAxis("Vertical") * moveSpeed;
        turnH = Input.GetAxis("Horizontal") * rotSpeed;
        transform.Translate(0, 0, moveV * Time.deltaTime);
        if (moveV != 0)
        {
            transform.Rotate(0, turnH, 0 * Time.deltaTime);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        GetComponents<AudioSource>()[0].Play();
    }
}
