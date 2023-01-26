using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    public string backToTitleScreen;

    // Start is called before the first frame update

    public void backtoTitle()
    {
        SceneManager.LoadScene(backToTitleScreen);
    }
}
