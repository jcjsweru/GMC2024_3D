using System.Collections;
using System.Collections.Generic;
using UnityEngine;
��
public class PlayerMovement : MonoBehaviour
{
    [Header("�ִ��� �������� ������")]
    [SerializeField] private float moveSpeed;

  ��private float dashLength = 6; // �������� ������

  ��void Update()
    {
        // ������

      ��float h = Input.GetAxis("Horizontal")?
      ��float v = Input.GetAxis("Vertical")?

      ��Vector3 dir = new Vector3(h, 0, v).normalized?

        transform.Translate(dir * moveSpeed * Time.deltaTime);

        // �뽬
        // �뽬�� �����ص� ��

      ��if(Input.GetKeyDown(KeyCode.Space)) transform.position += dir * dashLength;
    }
}
