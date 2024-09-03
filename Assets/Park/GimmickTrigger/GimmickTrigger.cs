using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GimmickTrigger : MonoBehaviour
{
    public bool testbool;
    [Header("GimmickInput을 설정할 수 있습니다.\n 설정값이 없을 경우 부모 오브젝트의 GimmickInput를 실행합니다")]
    public GimmickInput GimmickInput;
    public void InvokeEventRunOnTrigger()
    {
        if (GimmickInput != null)
        {
            GimmickInput.InvokeEvent();
        }
        else
        {
            Debug.LogWarning("gimmick input script not found in parent object!! Please add the gimmick input script to the parent object or place it as a child object of the object with gimmick input.");
        }
    }
    private void OnValidate()
    {

        GimmickInput GmmiInut = GetComponentInParent<GimmickInput>();
        if (GmmiInut != null)
        {
            GimmickInput = GmmiInut;
        }
        testbool = false;
    }
}
