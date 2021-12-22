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
            Debug.Log("¼±Ä§¹ü");
            // panel »¡°²°Ô ÀÌ¹Ì »¡°²°Ô µÇ¾îÀÖ´Ù¸é 
        }
        else if ((this.gameObject.transform.position.z - evaluateLine.transform.position.z) > 0.05f)
        {

        }
    }
}
