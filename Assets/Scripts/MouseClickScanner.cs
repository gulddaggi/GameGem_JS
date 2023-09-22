using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// ���콺 Ŭ���� �����ϴ� Ŭ����
public class MouseClickScanner : MonoBehaviour
{
    // ���콺 �̺�Ʈ Ʈ����
    public bool mouseEventEnable = true;

    public UnityEvent mouseClikedEvent;

    // ������Ʈ Ŭ���� �ߵ��ϴ� ����Ƽ �̺�Ʈ�Լ�
    public void OnMouseDown()
    {
        // ���� ī�޶� ȭ���� ��ũ�� ��ǥ�� ������� ���� ���콺 ��ǥ������ ray ����
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;

        // ray �������� Raycast ����. 
        if (Physics.Raycast(ray, out raycastHit) && mouseEventEnable) // ray�� ��ü�� �浹�� + Ʈ���� Ȱ��ȭ�� ���
        {
            //Debug.Log("�̺�Ʈ");
            if (raycastHit.transform.tag == "Event_Plate")
            {
                mouseEventEnable = false;
                mouseClikedEvent.Invoke();
            }
        }
    }

    public void InitScanner()
    {
        mouseEventEnable = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
