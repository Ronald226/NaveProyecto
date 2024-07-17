using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAsteroide : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 velocidadAngular = new Vector3 (Random.Range(-1,1),Random.Range(-1,1)).normalized; 
        rb.angularVelocity = Random.insideUnitSphere *velocidad;

    }
}
