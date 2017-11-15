using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour {

    public float moveSpeed;
    public float rotSpeed;
    public float moveV;
    public float turnH;
    public float totalFuel;
    public float currentFuel;
    public float totalHealth;
    public float currentHealth;
    public float damage;
    public Image hpBar;
    public Image fuelBar;
    public Rigidbody rbPlayer;
    public bool hit;

    public float magnitude;

    public AudioClip horn;
    public AudioClip crash;

    void Start ()
    {
        GetComponents<AudioSource>()[1].clip = horn;
        GetComponents<AudioSource>()[0].clip = crash;
        currentFuel = totalFuel;
        currentHealth = totalHealth;
        rbPlayer = GetComponent<Rigidbody>();
        hit = false;

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponents<AudioSource>()[1].Play();
        }

        if (moveV > 0)
        {
            currentFuel -= moveV * 0.5f * Time.deltaTime;
            fuelBar.fillAmount = currentFuel / totalFuel;
        }

        if (moveV < 0)
        {
            currentFuel += moveV * 0.5f * Time.deltaTime;
            fuelBar.fillAmount = currentFuel / totalFuel;
        }

        if (currentFuel >= totalFuel)
        {
            currentFuel = totalFuel;
        }
    }

    void FixedUpdate ()
    {
        moveV = Input.GetAxis("Vertical") * moveSpeed;
        turnH = Input.GetAxis("Horizontal") * rotSpeed;
        transform.Translate(0, 0, moveV * Time.deltaTime);
        if (moveV > 0)
        {
            transform.Rotate(0, turnH, 0 * Time.deltaTime);
        }

        if (moveV < 0)
        {
            transform.Rotate(0, -turnH, 0 * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Ground")
        {
            hit = true;
            if (collision.collider.tag != "Ground" && hit == true)
            {
                GetComponents<AudioSource>()[0].Play();
                currentHealth -= damage * Mathf.Abs(Input.GetAxis("Vertical"));
                currentHealth -= damage * Mathf.Abs(Input.GetAxis("Horizontal"));
                hpBar.fillAmount = currentHealth / totalHealth;
                hit = false;
            }
        }
    }
}
