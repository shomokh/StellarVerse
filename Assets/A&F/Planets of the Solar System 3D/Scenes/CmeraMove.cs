using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmeraMove : MonoBehaviour
{

    public float speed = 5f; // ”—⁄… Õ—ﬂ… «·ﬂ«„Ì—«

    void Update()
    {
        // Õ—ﬂ… «·ﬂ«„Ì—« Ì„Ì‰« ÊÌ”«—«
        float horizontalMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(Vector3.right * horizontalMovement);

        // Õ—ﬂ… «·ﬂ«„Ì—« ··√„«„ Ê«·Œ·›
        float verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * verticalMovement);

        // Õ—ﬂ… «·ﬂ«„Ì—« ··√⁄·Ï Ê«·√”›·
        float upDownMovement = Input.GetAxis("UpDown") * speed * Time.deltaTime;
        transform.Translate(Vector3.up * upDownMovement);
    }
}
