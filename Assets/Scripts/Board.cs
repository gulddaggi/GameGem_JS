using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 도마 클래스. 완성된 닭꼬치를 도마 위에 생성.
public class Board : MonoBehaviour
{
    // 닭꼬치 생성 위치 리스트
    public List<Vector3> skewerPosList = new List<Vector3>();

    public List<GameObject> skewers = new List<GameObject>();

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 도마 위에 완성된 닭꼬치 생성
    public void InstSkewer(GameObject skewer)
    {
        for (int i = 0; i < skewers.Count; i++)
        {
            if (skewers[i] == null)
            {
                GameObject obj = Instantiate(skewer, this.transform);
                obj.transform.localPosition = skewerPosList[i];
                obj.transform.localRotation = Quaternion.Euler(90f, 90f, 0f);
                obj.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                skewers[i] = obj;
                ++GameManager.Instance.CookableCount;
                break;
            }
        }
    }
}
