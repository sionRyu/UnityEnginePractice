using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager 
{
    public Action KeyAction = null;

    // ���� �����ϴ°� �ƴ� �ٸ� Ŭ������ ���� �ҷ����� ������ Update�� �ƴ� OnUpdate
    public void OnUpdate()
    {
        if (Input.anyKey == false)
        {
            return;
        }

        if (KeyAction != null)
        {
            KeyAction.Invoke();
        }
    }
}
