using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Grapple tester");
    }

}
