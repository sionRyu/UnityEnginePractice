using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {
        
    }

    float yAngle = 0.0f;
    void Update()
    {
        // 각각의 오브젝트에서 업데이트가 돌면 성능부하가 크므로 이벤트로 매니저에 만들어준다
        
    }
}
