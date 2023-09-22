using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 재료 생성 중간 매개 클래스. 막대 오브젝트가 해당 클래스 오브젝트의 자식으로 생성되므로 중간 매개로 사용.
public class SpeakToSkewer : MonoBehaviour
{
    public void SpeakInstEvent(int _index)
    {
        this.gameObject.GetComponentInChildren<Skewer>().InstIngredient(_index);
    }

    public void SpeakDelEvent(int _index)
    {
        this.gameObject.GetComponentInChildren<Skewer>().DelIngredient(_index);
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
