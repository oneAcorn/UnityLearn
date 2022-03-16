using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIK : MonoBehaviour
{
    private Animator anim;
    public bool ikHeadActive;
    public bool ikRightHandActive;
    public Transform rightHandPosReference;
    public Transform rightHandRotationReference;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Attack");
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (!anim)
        {
            return;
        }

        if (ikHeadActive)
        {
            //鼠标位置发出的射线
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane plane = new Plane(Vector3.forward, transform.position);
            float rayDistance;
            Vector3 target = Vector3.zero;
            if (plane.Raycast(cameraRay, out rayDistance))
            {
                //获取射线与平面交叉的点
                target = cameraRay.GetPoint(rayDistance);
            }

            anim.SetLookAtPosition(target);
            anim.SetLookAtWeight(1);
        }

        if (ikRightHandActive)
        {
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, 1f);

            anim.SetIKPosition(AvatarIKGoal.RightHand, rightHandPosReference.position);
            anim.SetIKRotation(AvatarIKGoal.RightHand, rightHandRotationReference.rotation);
        }
    }
}