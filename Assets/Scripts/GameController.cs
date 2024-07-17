using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{

    public GameObject obstaculos;
    public Vector3 obsValues;
    public int contadorObstaculos;
    public float spawnWait;
    public float starWait;
    public float waveWait;

    private int puntaje;
    public TMP_Text puntajeText;


    // Start is called before the first frame update

    void Start()
    {
        puntaje = 0;
        StartCoroutine(crearObstaculos());
        UpdatePuntaje();
    }
    
    // Update is called once per frame
    IEnumerator crearObstaculos()
    {
        yield return new WaitForSeconds(starWait);
        while (true)
        {
            for (int i=0; i<contadorObstaculos; i++) {
               Vector3 obsPosition = new Vector3(Random.Range(-obsValues.x,obsValues.x), obsValues.y, obsValues.z);
               Instantiate(obstaculos,obsPosition, Quaternion.identity);
               yield return new WaitForSeconds(spawnWait);
            
            }
          yield return new WaitForSeconds(waveWait);
        }

    }

    private void UpdatePuntaje()
    {
        puntajeText.text = "Puntuacion: " + puntaje;
    }
}
