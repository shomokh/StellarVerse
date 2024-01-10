using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Later : MonoBehaviour
{
    public TextMeshProUGUI textToDisplay;
    public float TimeToSplay = 5f;

    private void Start()
    {
        textToDisplay.gameObject.SetActive(true);

        StartCoroutine(HideLetterDelay(TimeToSplay));
    }

    IEnumerator HideLetterDelay(float countdown)
    { 
        yield return new WaitForSeconds(countdown);
        textToDisplay.gameObject.SetActive(false);

    }
}
