using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    public int bpm = 0; // bpm = 1�д� 4���� 1������ ����
    public int minute = 0; // ���� �ð�
    public int second = 0;
    public float beat = 0.0f;

    // 60bpm���� 4��Ʈ�� (4���� 4����) 1�ʸ��� 1��Ʈ�� �ö󰡹Ƿ� �ִ� 60���� ����; 
    // 1/8 ���ڴ� 0.5��, 1/16 ���ڴ� 0.25��, 1/32 ���ڴ� 0.125�ʸ��� 1��Ʈ�� �ö�;


    private void Update()
    {
        transform.position -= new Vector3(0, 0, 1) * Time.deltaTime ; // bpm�� ���� �ӵ� ������ �ʿ��� ����.
    }// ����� bpm�� ���� ��ġ�� ����
}
