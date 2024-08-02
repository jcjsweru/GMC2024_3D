using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform Player?

    private Vector3 camPos = new Vector3(0, 14.5f, -13.5f); // 변경하지 마세요
    
    void Update()ㅤ
    {
     ㅤ transform.position = Player.position + camPos? ㅤ
    }
}
