using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStonePosition : MonoBehaviour
{
    [SerializeField] private StoneBehaviour _prefabStone;
    [SerializeField] private Transform _startShootPoint;

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Mouse1))
        //{
        //    Fire();
        //}
    }

    private void Fire()
    {
        var stone = Instantiate(_prefabStone, _startShootPoint.position, _startShootPoint.rotation);
    }
}
