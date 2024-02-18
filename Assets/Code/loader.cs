using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loader : MonoBehaviour
{
    public int scint;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(scint);
    }
}
