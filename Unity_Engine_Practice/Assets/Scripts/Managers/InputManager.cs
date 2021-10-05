using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager 
{
    public Action KeyAction = null;

    // 직접 실행하는게 아닌 다른 클래스에 의해 불려지기 때문에 Update가 아닌 OnUpdate
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
