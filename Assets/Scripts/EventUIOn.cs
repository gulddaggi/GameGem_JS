using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventUIOn : MonoBehaviour
{
    // �̺�Ʈ UI ������Ʈ ���� �迭
    public GameObject[] eventUIArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ���� UI Ȱ��ȭ
    public void MakeUIOn()
    {
        eventUIArray[0].SetActive(true);
    }

    // ���� UI ��Ȱ��ȭ
    public void MakeUIOff()
    {
        eventUIArray[0].SetActive(false);
    }
}
