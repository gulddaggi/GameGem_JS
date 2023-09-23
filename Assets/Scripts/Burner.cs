using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 버너 클래스. 도마 위 음식을 버너 위 생성 및 버튼 액션 진입.
public class Burner : MonoBehaviour
{
    // 닭꼬치 생성 위치 리스트
    public List<Vector3> skewerPosList = new List<Vector3>();

    // 생성된 닭꼬치 저장 리스트
    public List<GameObject> skewers = new List<GameObject>();

    public GameObject[] particles;

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstSkewer(GameObject skewer)
    {
        for (int i = 0; i < skewers.Count; i++)
        {
            if (skewers[i] == null)
            {
                GameObject obj = Instantiate(skewer, this.transform);

                // 버너 위에 생성되도록 로컬 트랜스폼 변경
                obj.transform.localPosition = skewerPosList[i];
                obj.transform.localRotation = Quaternion.Euler(180f, 90f, 0f);
                obj.transform.localScale = new Vector3(1.5f, 1.5f, 1f);

                obj.GetComponent<Skewer>().index = i;
                obj.GetComponent<Skewer>().OnTheBurner(); // 요리 중 기능 수행.
                skewers[i] = obj;
                ++GameManager.Instance.CookingCount;

                // 버너에 아무 요리도 없을 경우 이펙트 활성화
                if (GameManager.Instance.CookingCount == 1) ActiveEffect();
                obj.transform.tag = "Skewer_cooking";
                break;
            }
        }
    }

    void ActiveEffect()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            particles[i].SetActive(true);
        }
    }

    void DeactiveEffect()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            particles[i].SetActive(false);
        }
    }
}
