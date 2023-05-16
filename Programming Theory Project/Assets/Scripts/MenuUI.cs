using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    private int gameMode { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartJumpingBall()
    {
        SceneManager.LoadScene(1);
        gameMode = 0;
    }

    public void StartShootingBall()
    {
        SceneManager.LoadScene(1);
        gameMode = 1;
    }
    
}
