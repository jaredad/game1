using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth { get; set; }
    public float maxHealth { get; set; }
    public Slider healthbar;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 20f;
        currentHealth = maxHealth;
        healthbar.value = healthPercent();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            Attack(6);
        }
    }

    void Attack(float damage)
        {
            currentHealth -= damage;
            healthbar.value = healthPercent();
            if (currentHealth <= 0){
                Die();
            }
        }

    float healthPercent()
        {
            return currentHealth / maxHealth;
        }
    
    void Die()
        {
            currentHealth = 0;
            healthbar.value = healthPercent();
            Debug.Log("You have died!");
        }
    }
