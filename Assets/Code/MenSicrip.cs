using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenSicrip : MonoBehaviour
{
    public Button button;

    public void load()
    {
        SceneManager.LoadScene(1);
    }
}
