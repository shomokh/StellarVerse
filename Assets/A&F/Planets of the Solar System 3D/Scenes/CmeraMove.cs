using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmeraMove : MonoBehaviour
{

    public float speed = 5f; // ���� ���� ��������

    void Update()
    {
        // ���� �������� ������ �������
        float horizontalMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(Vector3.right * horizontalMovement);

        // ���� �������� ������ ������
        float verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * verticalMovement);

        // ���� �������� ������ �������
        float upDownMovement = Input.GetAxis("UpDown") * speed * Time.deltaTime;
        transform.Translate(Vector3.up * upDownMovement);
    }
}
