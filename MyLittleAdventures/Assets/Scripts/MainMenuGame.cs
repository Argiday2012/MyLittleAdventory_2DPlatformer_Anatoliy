using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuGame : MonoBehaviour
{
    [SerializeField] private Toggle _music;
    [SerializeField] private AudioSource _mainMusic;

    //[SerializeField] private Toggle _sound;
    //[SerializeField] private AudioSource _mainSound;

    private void Start()
    {
        //_music.onValueChanged.AddListener(OnMusicClickHandler);
        //_sound.onValueChanged.AddListener(OnSoundClickHandler);
    }


    //private void OnMusicClickHandler(bool isOnMusic)
    //{
    //    if(isOnMusic == true)
    //    {
    //        _mainMusic.Play();
    //    }
    //    else
    //    {
    //        _mainMusic.Stop();
    //    }
    //}

    private void OnSoundClickHandler(bool isOnSound)
    {
        if(isOnSound == true)
        {
            Debug.Log("Sound true");
        }
        else
        {
            Debug.Log("Sound false");
        }
    }


    public void ContinueGame()
    {
        SceneManager.LoadScene("Main");
    }
}
