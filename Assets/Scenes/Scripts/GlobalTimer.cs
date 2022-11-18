using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timerDisplay01;
    public GameObject timerDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public static int extendScore;
 
    
    void Update()
    {
        extendScore = theSeconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
        
    }
    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timerDisplay01.GetComponent<TMPro.TextMeshProUGUI>().text = "" + theSeconds;
        timerDisplay02.GetComponent<TMPro.TextMeshProUGUI>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }

}
