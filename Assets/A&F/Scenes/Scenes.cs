using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void GamePlay()
    {

        SceneManager.LoadScene("GamePlay");


    }

    public void UI2()
    {
        SceneManager.LoadScene("UI2");
    }

    public void Overview()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void UI3()
    {
        SceneManager.LoadScene("UI3");
    }
}
