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
    static Managers instance; // ���ϼ��� ����ȴ�
    public static Managers GetInstance() { return instance; } // ������ �Ŵ����� ���� �´�


    void Start()
    {
        instance = this;
        

    }


    void Update()
    {
        
    }

    static void Init()
    {
        if (instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" }; // �� ���ӿ�����Ʈ ����� �̸��� @Managers
                go.AddComponent<Managers>(); // ������� ���� ������Ʈ�� �Ŵ��� ������Ʈ �߰�
            }

            DontDestroyOnLoad(go);
            instance = go.GetComponent<Managers>();
        }
       
        
    }
}
