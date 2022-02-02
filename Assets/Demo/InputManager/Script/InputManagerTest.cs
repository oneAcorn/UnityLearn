using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerTest : MonoBehaviour
{

    private void Update()
    {
        Test();
    }

    private void Test()
    {
        //down��up֮��ʱ,һֱΪtrue
        bool r1 = Input.GetButton("Jump");
        bool r2 = Input.GetButtonDown("Jump");
        bool r3 = Input.GetButtonUp("Jump");
        if (r1 || r2 || r3)
            Debug.Log($"Jump btn:{r1},Jump BtnDown:{r2},Jump BtnUp:{r3}");

        bool horiBtn = Input.GetButton("Horizontal");
        float horizontal = Input.GetAxis("Horizontal");
        //ֻ����-1,0,1��3��ֵ.
        float horizontalRaw = Input.GetAxisRaw("Horizontal");
        if (horiBtn)
            Debug.Log($"horizontal:{horizontal},horizontal Raw:{horizontalRaw}");
    }
}
