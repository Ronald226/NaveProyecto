using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public GameObject explosion;
    public GameObject naveExplosion;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AreaJuego")) return;

            Instantiate(explosion,transform.position,transform.rotation);

        if (other.CompareTag("Player"))
        {
            Instantiate(naveExplosion, other.transform.position, other.transform.rotation);

        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
