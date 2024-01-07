using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed = 6f;
    public float hoizontalInput;
    public float forwaedInput;
    public float jumpForce = 6;
    public Rigidbody rb;
   // public bool isGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), 3, PlayerPrefs.GetFloat("z"));

    }

    // Update is called once per frame
    void Update()
    {
        hoizontalInput = Input.GetAxis("Horizontal");
        forwaedInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwaedInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * hoizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) ) //&& isGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isGround = false;
        }


    }

   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }*/
    private void LateUpdate()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("z", transform.position.z);
    }
}
