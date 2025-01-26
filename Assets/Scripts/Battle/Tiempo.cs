/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;  

public class Tiempo : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text temps;

    private float restante;
    private bool enMarcha;
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    private void Awake() {
        enMarcha = true;
        restante = min*60 + seg;
    }
    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante = Time.deltaTime;
            if(restante < 1) {
                //Matar
            }
            int tempMin = (int)(restante/60);
            int tempSeg = (int)(restante % 60);
            temps.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }
}
*/