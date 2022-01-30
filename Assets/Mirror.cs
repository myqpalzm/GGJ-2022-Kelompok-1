using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mirror : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other) {
        if (SceneManager.GetActiveScene().name == "Light") {
            SceneManager.LoadScene(3);
        }
    }
}
