using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject note;
    int speed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        note.transform.position.z -= speed * Time.deltaTime;
    }

    int calculBpm
}
