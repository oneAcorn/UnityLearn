using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewCtrl : MonoBehaviour
{
    //��ת�ٶ�
    public float rotateSpeed = 1f;

    private void FixedUpdate()
    {
        CtrlPlayerView();
    }

    /// <summary>
    /// ������������������ҿ�
    /// </summary>
    private void CtrlPlayerView()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if (mouseX == 0 && mouseY == 0)
        {
            return;
        }

        //�����Update�����,��������FixedUpdate��,����Ҫ��ΪmouseX *= rotateSpeed *Time.deltaTime;
        mouseX *= rotateSpeed;
        mouseY *= rotateSpeed;

        //�˴��������������������ϵ��,�����������ҿ�ʱ,���岻�ᶯ,��������Ӧ������������ϵ.
        //this.transform.Rotate(-mouseY, mouseX, 0);

        this.transform.Rotate(-mouseY, 0, 0);
        //������ת,��Ҫ����������ϵ
        this.transform.Rotate(0, mouseX, 0, Space.World);
    }
}
