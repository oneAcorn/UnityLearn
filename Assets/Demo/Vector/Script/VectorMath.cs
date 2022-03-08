using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath : MonoBehaviour
{
    public Transform v1, v2;

    // Update is called once per frame
    void Update()
    {
        VectorSubtract();
    }

    /// <summary>
    /// 向量相减
    /// </summary>
    private void VectorSubtract()
    {
        Debug.DrawLine(Vector3.zero, v1.position - v2.position,Color.blue);
    }
}
