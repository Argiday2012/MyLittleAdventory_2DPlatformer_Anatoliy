using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject hero;


    private void Update()
    {
        transform.position = new Vector3(hero.transform.position.x, hero.transform.position.y + 2, -10f);
    }
}