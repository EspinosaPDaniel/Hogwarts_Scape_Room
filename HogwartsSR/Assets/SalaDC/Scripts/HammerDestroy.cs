using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HammerDestroy : MonoBehaviour
{
     public GameObject hammer;
	 public GameObject player;
   
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        ParticleSystem.MinMaxCurve newStartSize = new ParticleSystem.MinMaxCurve(5);
        ParticleSystem.MinMaxCurve newStartSizeSmoke = new ParticleSystem.MinMaxCurve(4);
        if (col.gameObject.name == "Martillo")
        {
            Destroy(gameObject);
            Debug.Log("eeee");
            StartCoroutine(DelayedAction());
            Debug.Log("iiii");
			player.SetActive(false);
            SceneManager.LoadScene("Sala Slitheryn");
            

        }
    }
     private IEnumerator DelayedAction()
    {
        yield return new WaitForSecondsRealtime(2f);

        // Acción a realizar después del retraso
        Debug.Log("Delayed action executed!");
    }
}
