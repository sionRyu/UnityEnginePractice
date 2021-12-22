using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    public int bpm = 0; // bpm = 1분당 4분의 1박자의 갯수
    public int minute = 0; // 곡의 시간
    public int second = 0;
    public float beat = 0.0f;

    // 60bpm에서 4비트는 (4분의 4박자) 1초마다 1비트씩 올라가므로 최대 60개가 생성; 
    // 1/8 박자는 0.5초, 1/16 박자는 0.25초, 1/32 박자는 0.125초마다 1비트가 올라감;


    private void Update()
    {
        transform.position -= new Vector3(0, 0, 1) * Time.deltaTime ; // bpm에 따라 속도 수정이 필요할 듯함.
    }// 배속은 bpm에 영향 미치지 않음
}
