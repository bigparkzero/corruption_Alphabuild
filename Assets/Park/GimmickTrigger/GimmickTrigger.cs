using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GimmickTrigger : MonoBehaviour
{
    public bool testbool;
    [HideInInspector] public bool isTriggered;
    [Header("GimmickInput�� ������ �� �ֽ��ϴ�.\n �������� ���� ��� �θ� ������Ʈ�� GimmickInput�� �����մϴ�")]
    public GimmickInput GimmickInput;
    private void Start()
    {
        isTriggered = false;
    }
    public void InvokeEventRunOnTrigger()
    {
        if (GimmickInput != null)
        {
            isTriggered = true;
            GimmickInput.TriggerCheck();
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
