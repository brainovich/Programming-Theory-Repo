using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> avatars;

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(avatars[MainManager.Instance.m_gameMode]);
    }

}
