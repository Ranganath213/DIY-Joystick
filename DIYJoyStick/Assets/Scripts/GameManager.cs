using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Animation controllerAnim;
    public GameObject PFX1;
    public GameObject PFX2;
    public GameObject exitBtn;
    public GameObject completedBtn;
    private void Awake()
    {

        if (Instance == null)
            Instance = this;
        exitBtn.SetActive(false);
        PFX1.SetActive(false);
        PFX2.SetActive(false);

    }


    public void FinishAnim()
    {
        PFX1.SetActive(true);
        PFX2.SetActive(true);
        PFX1.GetComponent<ParticleSystem>().Play();
        PFX2.GetComponent<ParticleSystem>().Play();
        controllerAnim.Play();
        StartCoroutine(Wait());
        completedBtn.SetActive(false);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        exitBtn.SetActive(true);
    }

    public void LoadScene()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
    }

    public Painter painter;
}
