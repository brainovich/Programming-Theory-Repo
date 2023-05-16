using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{


    public void StartJumpingBall()
    {
        SceneManager.LoadScene(1);

        MainManager.Instance.m_gameMode = 0;
    }

    public void StartShootingBall()
    {
        SceneManager.LoadScene(1);

        MainManager.Instance.m_gameMode = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
