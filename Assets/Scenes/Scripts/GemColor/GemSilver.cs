using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    public GameObject newColor;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
        StartCoroutine(NewColorOff());
    }
   
    IEnumerator NewColorOff()
    {
        newColor.SetActive(true);
        yield return new WaitForSeconds(2);
    }
    }
