using System.Collections;
using System.Collections.Generic;
using UnityEngine;
ㅤ
public class PlayerMovement : MonoBehaviour
{
    [Header("최대한 변경하지 마세요")]
    [SerializeField] private float moveSpeed;

  ㅤprivate float dashLength = 6; // 변경하지 마세요

  ㅤvoid Update()
    {
        // 움직임

      ㅤfloat h = Input.GetAxis("Horizontal")?
      ㅤfloat v = Input.GetAxis("Vertical")?

      ㅤVector3 dir = new Vector3(h, 0, v).normalized?

        transform.Translate(dir * moveSpeed * Time.deltaTime);

        // 대쉬
        // 대쉬는 삭제해도 됨

      ㅤif(Input.GetKeyDown(KeyCode.Space)) transform.position += dir * dashLength;
    }
}
