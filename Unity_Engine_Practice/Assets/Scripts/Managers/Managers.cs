using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviour �� ���� C#���ϸ� ������Ʈ�ν� ������Ʈ�� ���� �� �ִ�.
// �Ŵ��� Ŭ������ ��ҿ� �˴� �Ϲ����� C#Ŭ������ ����� ���ؼ� MonoBehaviour�� �����
// MonoBehaviour�� �����Ǹ� ������Ʈ�ν� �ν��� ���� ���ϱ� ������ �����Լ� ����
// ��������� Main�Լ��� ������ Start�� ������ ������ ��ؾ� ����?
// �׳� MonoBehaviour�� ���̰� �������Ʈ�� ���� ������Ʈ�� ������!
public class Managers : MonoBehaviour
{
    static Managers s_instance; // ���ϼ��� ����ȴ�
    public static Managers Instance { get { Init(); return s_instance; } } // ������ �Ŵ����� ���� �´�

    // ������ Managers�� �ϳ��ۿ� �����Ƿ� �׳� ��ȯ����
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
                go = new GameObject { name = "@Managers" }; // �� ���ӿ�����Ʈ ����� �̸��� @Managers
                go.AddComponent<Managers>(); // ������� ���� ������Ʈ�� �Ŵ��� ������Ʈ �߰�
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
