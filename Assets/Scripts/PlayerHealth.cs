using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth { get; set; }
    public float maxHealth { get; set; }
    public Slider healthbar;
    public Text text;
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
            text.text = "Loser!";
        }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name[0] == 'O')
        {
            Attack(2.5f);
        }
    }
}
