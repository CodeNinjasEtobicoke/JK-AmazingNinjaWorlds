using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Level1()
    {
        PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene("Level1");
    }

    public void level2()
    {
        //playerprefs.deletekey("lives_left");
        SceneManager.LoadScene("level2");
    }

    public void level3()
    {
        //playerprefs.deletekey("lives_left");
        SceneManager.LoadScene("level3");
    }
    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
