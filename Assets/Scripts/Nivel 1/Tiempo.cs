using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{ 
    [SerializeField] int min;
    [SerializeField] float seg;
    [SerializeField] TextMeshProUGUI tiempo;
 
    private string minText, segText;
    // Update is called once per frame
    void FixedUpdate()
    { 
        seg -= Time.fixedDeltaTime;
        if(seg <= 0) {
            if(min != 0) {
                min--;
                seg = 60;
            }
        }
        if(min < 10) {
            minText = "0" + min.ToString();
        } else {
            minText = min.ToString();
        }

        if(seg < 10) {
            segText = "0" + ((int)seg).ToString();
        } else {
            segText = ((int)seg).ToString();
        }
        tiempo.text = "" + minText + ":" + segText;
    }
 
}
