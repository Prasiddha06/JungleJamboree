using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHome : MonoBehaviour
{
    public void SceneMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
