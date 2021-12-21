using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager m_Instance;

    void Start()
    {
        
    }

    private void Awake()
    {
        if (m_Instance != null)
        {
            Instantiate(m_Instance);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
