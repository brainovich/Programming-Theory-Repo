using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    [SerializeField] List<GameObject> avatars;
    private int gameMode;
    public int m_gameMode
    {
        get { return gameMode; }
        set
        {
            if (value < 0 || value > 2)
            {
                Debug.LogError("There is no such game mode");
            }
            else
            {
                gameMode = value;
            }
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
