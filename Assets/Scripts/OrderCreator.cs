using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 주문 생성 및 관리 클래스
public class OrderCreator : MonoBehaviour
{
    int orderCount = 1;

    public GameObject[] orderObjs;

    public List<int> orderList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        OrderCrete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OrderCrete()
    {
        for (int i = 0; i < orderList.Count; i++)
        {
            // 주문이 비어있는 경우 주문 생성
            if (orderList[i] == 0)
            {
                int orderNumber = Random.Range(1, 4); // 1~3번 중 무작위 주문 생성
                orderList[i] = orderNumber;
                DisplayOrder(i, orderNumber);
                
            }
        }
    }

    // 생성된 주문 출력
    void DisplayOrder(int _index, int _orderNumber)
    {
        orderObjs[_index].GetComponentInChildren<Text>().text = "주문 " + orderCount + " : " + _orderNumber + "번";
        ++orderCount;
    }

    // 주문 최신화.
    void UpdateOrder()
    {

    }
}
