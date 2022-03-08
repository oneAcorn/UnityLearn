using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// LookAt是以z轴方向(也就是物体前方)盯着目标点
/// </summary>
public class LookAtTest : MonoBehaviour
{
    public Transform targetObj;

    // Update is called once per frame
    void Update()
    {
        //从世界坐标起点,到此物体的位置
        var target = targetObj.forward;
        var target2=new Vector3(target.x,0,target.z);
        Debug.DrawLine(Vector3.zero, target,Color.cyan);
        Debug.DrawLine(transform.position, target,Color.cyan);
        // Debug.DrawLine(Vector3.zero, target2,Color.magenta);
        // Debug.DrawLine(transform.position, target2,Color.magenta);
        Debug.Log($"lookAt {target},{target2}");
        transform.LookAt(target);
        // transform.rotation = Quaternion.LookRotation(target);
    }
}
