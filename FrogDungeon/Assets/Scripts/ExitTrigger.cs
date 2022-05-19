using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        FindObjectOfType<GameManager>().ExitGame();
    }
}
