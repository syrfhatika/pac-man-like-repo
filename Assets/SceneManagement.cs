using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Play()
    {
	SceneManager.LoadScene("Scene Week 1");
    }

    public void Exit()
    {
	Application.Quit();
    }
}
