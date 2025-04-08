using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menusload : MonoBehaviour
{
    public AudioSource SFX;
    // Start is called before the first frame update
    public void playbut()
    {
        SFX.mute = false;
        StartCoroutine(sfxplayload());
        IEnumerator sfxplayload()
        {
            SFX.Play();
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("SampleScene");
            Debug.Log("loaded");
        }
       
    }

    // Update is called once per frame
    public void quitbut()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
