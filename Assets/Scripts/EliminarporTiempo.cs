using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarporTiempo : MonoBehaviour
{

    public float tiempovida;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempovida);
    }

    
}
