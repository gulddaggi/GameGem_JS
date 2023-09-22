using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 진행과 관련된 각종 기능을 수행하는 싱글톤 클래스.
public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    // 도마 위에 존재하는 요리 가능한 음식 수
    int cookableCount = 0;

    public int CookableCount
    {
        get
        {
            return cookableCount;
        }
        set
        {
            cookableCount = value;
        }
    }

    private void Awake()
    {
        // 싱글톤 구현
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }
    }

    // 접근 권한 설정
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }

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
