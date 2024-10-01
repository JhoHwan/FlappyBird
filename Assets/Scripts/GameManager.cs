using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public void Awake()
    {
        if(Instance == null)
            Instance = this;
        else 
            Destroy(this);

        DontDestroyOnLoad(this);
    }


    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }
}
