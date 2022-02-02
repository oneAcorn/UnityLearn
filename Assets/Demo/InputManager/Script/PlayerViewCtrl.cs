using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewCtrl : MonoBehaviour
{
    //旋转速度
    public float rotateSpeed = 1f;

    private void FixedUpdate()
    {
        CtrlPlayerView();
    }

    /// <summary>
    /// 鼠标控制摄像机上下左右看
    /// </summary>
    private void CtrlPlayerView()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if (mouseX == 0 && mouseY == 0)
        {
            return;
        }

        //如果在Update里调用,而不是在FixedUpdate里,则需要改为mouseX *= rotateSpeed *Time.deltaTime;
        mouseX *= rotateSpeed;
        mouseY *= rotateSpeed;

        //此代码的左右是沿自身坐标系的,但是人类左右看时,身体不会动,所以左右应该是世界坐标系.
        //this.transform.Rotate(-mouseY, mouseX, 0);

        this.transform.Rotate(-mouseY, 0, 0);
        //左右旋转,需要沿世界坐标系
        this.transform.Rotate(0, mouseX, 0, Space.World);
    }
}
