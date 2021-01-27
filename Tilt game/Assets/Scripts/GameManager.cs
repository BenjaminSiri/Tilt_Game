using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string[] Scenes = { "Level 1", "Level 2", "Level 3", "Level 4", "Level 5","Level 6", "Level 7"};
    public int currentScene;

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

    public void nextScene()
    {
        Debug.Log("Next scene");
        currentScene++;
        Debug.Log("" + currentScene);
        Debug.Log(Scenes[currentScene]);
        SceneManager.LoadScene(Scenes[currentScene]);
    }

    public void StartButton()
    {
        currentScene = 0;
        SceneManager.LoadScene(Scenes[currentScene]);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
