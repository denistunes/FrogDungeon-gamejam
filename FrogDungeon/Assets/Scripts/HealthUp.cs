using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D hitInfo) {
        
        PlayerStats pStats = hitInfo.GetComponent<PlayerStats>();
        if (pStats.currentHealth < pStats.MaxHealth)
        {
            FindObjectOfType<AudioManager>().Play("Beep");
            pStats.TakeHealth(1);
            Destroy(gameObject);
        }

        //if(pStats.currentHealth > pStats.MaxHealth)
        //{
        //    Debug.Log("Dont't Take Health");
        //}
    }
}
