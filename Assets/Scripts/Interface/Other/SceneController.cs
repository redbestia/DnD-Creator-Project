using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void wlaczPostac()
    {
        SceneManager.LoadScene(1);  
    }

    public void wlaczMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void wylaczAplikacje()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
