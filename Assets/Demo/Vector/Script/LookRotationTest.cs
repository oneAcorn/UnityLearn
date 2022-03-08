using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// LookRotation(target.forward)是和目标旋转保持一致
/// </summary>
public class LookRotationTest : MonoBehaviour
{
    public Transform targetObj;
    // Update is called once per frame
    void Update()
    {
        var target = targetObj.forward;
        Debug.DrawLine(Vector3.zero, target,Color.yellow);
        Debug.DrawLine(transform.position, target,Color.yellow);
        Debug.Log($"lookAt {target}");
        // transform.LookAt(target);
        transform.rotation = Quaternion.LookRotation(target);
    }
}
