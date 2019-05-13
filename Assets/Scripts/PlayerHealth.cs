using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    // Player's health
    public int currentHealth;
    public int maxHealth = 3;

    public GameObject healthUI;
    public GameObject numberCoins;
    public Sprite[] hearthSprites;
    public Image hearthIU;
    Camera m_MainCamera;

    void Start()
    {
        // setting the lives in the top left corner
        float a = 0.93f;
        healthUI.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(a, a, 4));
        numberCoins.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.07F, a, 4));
        currentHealth = maxHealth;
    }
    

    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Die();
        }

        hearthIU.sprite = hearthSprites[currentHealth];       
    }

    public void Die()
    {
        // for now if the player dies we restart the level
        currentHealth = 0;
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
