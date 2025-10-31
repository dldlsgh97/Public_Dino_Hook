using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject GameSceneManager;
    public GameObject StartSceneManager;

    public bool Is_StorySlide = true;
    public int PlayerSprite = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameSceneManager = null;
        StartSceneManager = null;
        if (scene.name == "GameScene")
            GameSceneManager = GameObject.FindGameObjectWithTag("GameSceneManager");
        else if (scene.name == "StartScene")
            StartSceneManager = GameObject.FindGameObjectWithTag("StartSceneManager");
    }
    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


}
