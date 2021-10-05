using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviour 가 붙은 C#파일만 컴포넌트로써 오브젝트에 붙일 수 있다.
// 매니저 클래스를 평소에 알던 일반적인 C#클래스로 만들기 위해서 MonoBehaviour를 지운다
// MonoBehaviour가 삭제되면 컴포넌트로써 인식을 하지 못하기 때문에 내장함수 몼씀
// 결과적으로 Main함수도 못쓰고 Start도 못쓰기 때문에 어떡해야 하지?
// 그냥 MonoBehaviour를 붙이고 빈오브젝트를 만들어서 컴포넌트를 붙이자!
public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성이 보장된다
    public static Managers Instance { get { Init(); return s_instance; } } // 유일한 매니저를 갖고 온다

    // 어차피 Managers가 하나밖에 없으므로 그냥 반환해줌
    InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; } }


    void Start()
    {
            Init();
    }


    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" }; // 빈 게임오브젝트 만들고 이름이 @Managers
                go.AddComponent<Managers>(); // 만들어준 게임 오브젝트에 매니저 컴포넌트 추가
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
