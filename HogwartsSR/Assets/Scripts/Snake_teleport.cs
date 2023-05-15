using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake_teleport : MonoBehaviour
{
    public float teleportInterval = 25f; // Intervalo de tiempo entre teletransportaciones
    public Vector3 teleportPosition1 = new Vector3(-7.19, -2.23, 4.02); // Primera posición de teletransportación
    public Vector3 teleportPosition2 = new Vector3(2.39, 1.72, 5.08); // Segunda posición de teletransportación

    private float timer; // Temporizador para determinar cuándo teletransportar

    // Start is called before the first frame update
    void Start()
    {
        targetposition = teleportPosition2.position; // Empezar en el segundo punto de teletransporte
    }

    // Update is called once per frame
    void Update()
    {
        // Añadir tiempo desde el último frame al temporizador
        timer += Time.deltaTime;

        // Si el temporizador alcanza el intervalo de tiempo deseado, teletransportar el objeto
        if (timer >= teleportInterval)
        {
            // Cambiar la posición del objeto a la posición 2 si está en la posición 1, o viceversa
            transform.position = (transform.position == teleportPosition1) ? teleportPosition2 : teleportPosition1;

            // Reiniciar el temporizador
            timer = 0f;
        }
    }
}
