using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake_teleport : MonoBehaviour
{
    public float teleportInterval = 25f; // Intervalo de tiempo entre teletransportaciones
    public Vector3 teleportPosition1 = new Vector3(-7.19, -2.23, 4.02); // Primera posici�n de teletransportaci�n
    public Vector3 teleportPosition2 = new Vector3(2.39, 1.72, 5.08); // Segunda posici�n de teletransportaci�n

    private float timer; // Temporizador para determinar cu�ndo teletransportar

    // Start is called before the first frame update
    void Start()
    {
        targetposition = teleportPosition2.position; // Empezar en el segundo punto de teletransporte
    }

    // Update is called once per frame
    void Update()
    {
        // A�adir tiempo desde el �ltimo frame al temporizador
        timer += Time.deltaTime;

        // Si el temporizador alcanza el intervalo de tiempo deseado, teletransportar el objeto
        if (timer >= teleportInterval)
        {
            // Cambiar la posici�n del objeto a la posici�n 2 si est� en la posici�n 1, o viceversa
            transform.position = (transform.position == teleportPosition1) ? teleportPosition2 : teleportPosition1;

            // Reiniciar el temporizador
            timer = 0f;
        }
    }
}
