using UnityEngine;

public class TransportFinalstep : MonoBehaviour
{
    public Transform teleportTarget; // La posición de destino a la que se teletransportará el jugador y el objeto
    public int prueba=0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            prueba = 1;
            other.transform.position = teleportTarget.position;
        }

    }


}