using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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

    // 중간 매개 클래스
    private SpeakToSkewer speakToSkewer;

    // Start is called before the first frame update
    void Start()
    {
        speakToSkewer = GetComponentInParent<SpeakToSkewer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    // 재료 생성
    public void InstIngredient(int _index)
    {
        GameObject obj = Instantiate(ingredientPrefList[_index], this.transform);
        obj.transform.localPosition = ingredientPosList[count];
        obj.GetComponent<Ingredient>().Index = count;
        //curInstList.Add(obj);
        ++count;
        if (count == 6)
        {
            speakToSkewer.SkewerDoneEvent(this.gameObject);
        }
    }

    // 재료 삭제
    public void DelIngredient(int _index)
    {
        if (_index + 1 == count) // 제일 끝에 있는 재료일 경우
        {
            DestroyImmediate(this.transform.GetChild(_index).gameObject);
            //curInstList.Remove(curInstList[_index]);
            --count;
        }
    }
   
}
