using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelector : MonoBehaviour
{

    public void StartLevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void StartLevel3()
    {
        SceneManager.LoadScene(4);
    }

}
