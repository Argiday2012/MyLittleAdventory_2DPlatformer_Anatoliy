using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuGame : MonoBehaviour
{
    [SerializeField] private Toggle _music;

    private void Start()
    {
        _music.onValueChanged.AddListener(OnMusicClickHandler);
    }


    private void OnMusicClickHandler(bool isOn)
    {
        Debug.Log($"isOn: {isOn}");
    }


    public void ContinueGame()
    {
        SceneManager.LoadScene("Main");
    }
}
