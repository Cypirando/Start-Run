using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;
    public GameObject newColor;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 100;
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
