using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    public string first_Scene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(first_Scene);
    }

    public void OpenOptions()
    {

    }

    public void ClosedOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
