using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string nextScene;

    public void LoadSceneSelect()
    {
        SceneManager.LoadScene(nextScene);
    }
}
