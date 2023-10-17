using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //vendosja e emrit te skenes
    public string sceneName;


    void OnTriggerEnter()
    {
        //rilancimi i skriptit
        EditorSceneManager.LoadScene(sceneName);
    }
}
