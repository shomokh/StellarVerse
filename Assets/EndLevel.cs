using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public float distanceFromPlayer = 5.0f;
    public string nextScene = "Overview";
    private GameObject player;
    private bool playerInRange;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        CheckIfPlayerInRange();
    }

    void CheckIfPlayerInRange()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= distanceFromPlayer)
        {
            playerInRange = true;
            LoadNextScene();
        }
        else
        {
            playerInRange = false;
        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene("Overview");
    }
    // Update is called once per frame
    void Update()
    {
        if (!playerInRange)
        {
            CheckIfPlayerInRange();
        }
    }
}
