using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public GameObject player;
    public GameObject[] items;
    public string nextLevel = "Overview";
    private bool allItemsCollected;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        items = GameObject.FindGameObjectsWithTag("Item");
        allItemsCollected = false;
    }

    void Update()
    {
        CheckItemCount();
    }

    void CheckItemCount()
    {
        foreach (GameObject item in items)
        {
            if (item != null)
            {
                return;
            }
        }
        allItemsCollected = true;
        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene("Overview");
    }
}
