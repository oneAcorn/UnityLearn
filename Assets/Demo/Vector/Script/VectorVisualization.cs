using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorVisualization : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        DrawLine();
    }

    private void DrawLine()
    {
        Vector3 pos = transform.position;
        //从世界坐标起点,到此物体的位置
        Debug.DrawLine(Vector3.zero, pos);
        //模
        float magnitude1 = transform.position.magnitude;
        float magnitude2 = Vector3.Distance(Vector3.zero, pos); //和magnitude1一样.
        //方向
        Vector3 normalizeVec1 = pos / pos.magnitude;
        Vector3 normalizeVec2 = pos.normalized; //和normalizeVec1一样.
        //绘制向量的方向
        Debug.DrawLine(Vector3.zero, normalizeVec1, Color.red);
    }
}
