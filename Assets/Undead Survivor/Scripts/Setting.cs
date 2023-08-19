using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    RectTransform rect;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    public void Show()
    {
        rect.localScale = Vector3.one;
        GameManager.instance.Stop();
    }

    public void Resume()
    {
        rect.localScale = Vector3.zero;
        GameManager.instance.Resume();
    }

    public void GoMain()
    {
        if (GameManager.instance.kill > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", GameManager.instance.kill);

        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        if (GameManager.instance.kill > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", GameManager.instance.kill);

        GameManager.instance.GameQuit();
    }
}
