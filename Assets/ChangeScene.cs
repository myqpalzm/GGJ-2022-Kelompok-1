using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLight()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadDark()
    {
        SceneManager.LoadScene(3);
    }
}
