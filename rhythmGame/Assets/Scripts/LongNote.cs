using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongNote : MonoBehaviour
{
    public GameObject evaluateLine;


    private void Update()
    {
        if ((this.gameObject.transform.position.z - evaluateLine.transform.position.z)< 0.05f)
        {
            Debug.Log("��ħ��");
            // panel ������ �̹� ������ �Ǿ��ִٸ� 
        }
        else if ((this.gameObject.transform.position.z - evaluateLine.transform.position.z) > 0.05f)
        {

        }
    }
}
