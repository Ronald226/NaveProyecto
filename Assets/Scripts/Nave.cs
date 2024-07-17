using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Limites
{
    public float xMin, xMax, zMin, zMax;
}

public class Nave : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [Header("Movimiento")]
    public float velocidad;
    public float inclinacion;
    public Limites limites;

    [Header("Disparo")]
    public GameObject disparo;
    public Transform disparar;
    public float tasaDisparo;
    private float nextLaser = 0;

    private AudioSource audioSource;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time > nextLaser)
        {
            nextLaser = Time.time + tasaDisparo;
            Instantiate(disparo,disparar.position, Quaternion.identity);
            audioSource.Play();
        }

    }
    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 mover = new Vector3(moverHorizontal, 0f, moverVertical);
        rb.velocity = mover * velocidad;

        rb.position = new Vector3(Mathf.Clamp(rb.position.x, limites.xMin, limites.xMax), 0f, Mathf.Clamp(rb.position.z, limites.zMin, limites.zMax));
        rb.rotation = Quaternion.Euler(0f, 0f, rb.velocity.x * -inclinacion);
    }
}

