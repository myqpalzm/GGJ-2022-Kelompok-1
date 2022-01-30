using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Sprite[] health;
    public int healthState;
    public GameObject player;
    public Sprite currentHealth;

    void Awake()
    {
        healthState = 7;
        currentHealth = health[0];
    }

    void Update()
    {
        for (int i = 7; i >= healthState; i--) {
            if (i == 1) {
                currentHealth = health[6];
            } else if (i == 2) {
                currentHealth = health[5];
            } else if (i == 3) {
                currentHealth = health[4];
            } else if (i == 4) {
                currentHealth = health[3];
            } else if (i == 5) {
                currentHealth = health[2];
            } else if (i == 6) {
                currentHealth = health[1];
            } else if (i == 7) {
                currentHealth = health[0];
            }
        }

        gameObject.GetComponent<Image>().sprite = currentHealth;
    }
}
