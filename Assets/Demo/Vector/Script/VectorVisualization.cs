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
        //�������������,���������λ��
        Debug.DrawLine(Vector3.zero, pos);
        //ģ
        float magnitude1 = transform.position.magnitude;
        float magnitude2 = Vector3.Distance(Vector3.zero, pos); //��magnitude1һ��.
        //����
        Vector3 normalizeVec1 = pos / pos.magnitude;
        Vector3 normalizeVec2 = pos.normalized; //��normalizeVec1һ��.
        //���������ķ���
        Debug.DrawLine(Vector3.zero, normalizeVec1, Color.red);
    }
}
