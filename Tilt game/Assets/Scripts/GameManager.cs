using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string currentScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

    public void StartButton()
    {
        currentScene = "Level 1";
        SceneManager.LoadScene("Level 1");
    }

    public void Scene2()
    {
        currentScene = "Level 2";
        SceneManager.LoadScene("Level 2");
    }

    public void Scene3()
    {
        currentScene = "Level 3";
        SceneManager.LoadScene("Level 3");
    }
}
