using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public static bool IsFinish = false;
    public GameObject FinishWindow;
    public GameObject Hero;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            IsFinish = true;
            FinishWindow.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
