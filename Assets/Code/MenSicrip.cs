using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenSicrip : MonoBehaviour
{
    public Button button;
    public Image imgCat;
    public GameObject quitTxt;
    public Sprite presedSpi;
    public Sprite mainSpi;

    private AudioSource audioSrc;
    private bool audioControl = true;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void load()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitBtn()
    {
        StartCoroutine(QuitTxtTimer());
    }

    public void CatBtn()
    {
        if(audioControl == true)
        {
            StartCoroutine(CatAudio());
        }
    }

    IEnumerator QuitTxtTimer()
    {
        quitTxt.SetActive(true);
        yield return new WaitForSeconds(5f);
        quitTxt.SetActive(false);
    }

    IEnumerator CatAudio()
    {
        imgCat.sprite = presedSpi;
        audioSrc.Play();
        audioControl = false;
        yield return new WaitForSeconds(2f);
        audioSrc.Stop();
        audioControl = true;
        imgCat.sprite = mainSpi;
    }
}
