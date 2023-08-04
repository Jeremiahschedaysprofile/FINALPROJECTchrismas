using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 200;
    public GameManagerScript gameManager;
    private bool isDead;
    


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0 && !isDead)
        {
            gameManager.gameOver();
            isDead = true;
            Debug.Log("Dead");
        }
    }
}