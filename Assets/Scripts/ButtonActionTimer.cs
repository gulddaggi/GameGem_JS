using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActionTimer : MonoBehaviour
{
    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 15f)
        {
            Debug.Log(time);
            time += Time.deltaTime;
            Color curColor = this.GetComponent<TextMesh>().color;
            Color addColor = new Color(curColor.r, curColor.g - (time / 15) * Time.deltaTime, curColor.b, curColor.a);
            this.GetComponent<TextMesh>().color = addColor;
        }
        else if (time >= 15f)
        {
            this.GetComponentInParent<Skewer>().ButtonActionTimeOver();
            this.GetComponent<TextMesh>().text = "X";
        }
    }

    
}
