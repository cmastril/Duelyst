using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void OnPlayButtonPress()
    {
        SceneManager.LoadScene("PlayMenu");
    }

    public void OnCollectionButtonPress()
    {

    }
}