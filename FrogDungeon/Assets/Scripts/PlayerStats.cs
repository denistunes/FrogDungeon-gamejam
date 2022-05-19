using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int MaxHealth = 4;
    public int currentHealth;

    public CameraFollow CamFollow;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            CamFollow.enabled = false;
            Die();
        }
    }

    public void TakeHealth(int Up)
    {
        currentHealth += Up;

        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
        FindObjectOfType<GameManager>().DeadGame();
        Destroy(gameObject);
    }
}
