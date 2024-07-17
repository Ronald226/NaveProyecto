using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveLaser : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;
    public float velocidad;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward*velocidad;
    }
}
