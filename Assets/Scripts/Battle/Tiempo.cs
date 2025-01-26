using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{ 
    [SerializeField] int min;
    [SerializeField] float seg;
    [SerializeField] TextMeshProUGUI tiempo;
 
    // Update is called once per frame
    void Update()
    { 
        seg -= Time.deltaTime;
        if(seg <= 0) {
            if(min != 0) {
                min--;
                seg = 60;
            }
        }

        tiempo.text = "" + min.ToString() + ":" + ((int)seg).ToString() ;
    }
 
}
