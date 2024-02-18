using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class change : MonoBehaviour
{

    public Sprite Sprite;
    public GameObject býc;
    public GameObject b;
    public GameObject kanlý;
    public GameObject carpý;
    public GameObject trig;
    public GameObject kurt;
    public GameObject uý;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
        býc.SetActive(true);
        StartCoroutine(tie());
        
        StartCoroutine(cor());


    }
    IEnumerator tie()
    {

        yield return new WaitForSeconds(2);
        b.SetActive(true);
    }
    IEnumerator cor()
    {
        yield return new WaitForSeconds(3);
        b.SetActive(false);
        býc.SetActive(false) ;
        kanlý.SetActive(true);
        carpý.SetActive(true);
        trig.SetActive(true);
    }


    public void kurts()
    {
        StartCoroutine(kur());


    }

    IEnumerator kur()
    {

        yield return new WaitForSeconds(2);
        b.SetActive(true);
        kurt.SetActive(true);
        uý.SetActive(false);
    }

}
