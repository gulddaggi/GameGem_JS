using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 닭꼬치 클래스
public class Skewer : MonoBehaviour
{
    // 재료 생성 위치 리스트
    public List<Vector3> ingredientPosList = new List<Vector3>();

    // 재료 프리팹 리스트
    public List<GameObject> ingredientPrefList = new List<GameObject>();

    // 현재 생성된 오브젝트 리스트
    public List<GameObject> curInstList = new List<GameObject>();

    // 현재 생성된 오브젝트 수
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstIngredient(int _index)
    {
        GameObject obj = Instantiate(ingredientPrefList[_index], this.transform);
        obj.transform.localPosition = ingredientPosList[count];
        ++count;
    }

}
