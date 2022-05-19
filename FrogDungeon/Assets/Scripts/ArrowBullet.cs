using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBullet : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        PlayerStats pStats = hitInfo.GetComponent<PlayerStats>();
        if (pStats != null)
        {
            FindObjectOfType<AudioManager>().Play("Hurt");
            pStats.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}
