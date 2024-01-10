using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour
{
    public int numItemsTotal; // The total number of item types in the game
    public int[] itemCounts; // An array to store the count of each item type
    public GameObject[] itemIcons; // An array to store the item icon objects in the UI Panel

    // Initialization
    void Start()
    {
        itemCounts = new int[numItemsTotal];
        // Set up your items here, such as by adding prefabs to your game.
    }

    // Function to be called whenever the player collects an item
    public void AddItem(int itemIndex)
    {
        itemCounts[itemIndex]++;
        // Update the UI Panel icon for the item type here
    }

    // Function to check if all items are collected
    public bool AllItemsCollected()
    {
        foreach (int count in itemCounts)
        {
            if (count == 0) return false;
        }
        return true;
    }

    // Function to move to the next level when all items are collected
    public void NextLevel()
    {
        if (AllItemsCollected())
        {
            // Proceed to the next level here, such as by loading a new scene.
            SceneManager.LoadScene("Overview");
        }
    }
}
