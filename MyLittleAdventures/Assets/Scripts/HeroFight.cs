using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFight : MonoBehaviour
{
    private float _timeBtwAttack;
    [SerializeField] private float _startBtwAttack;
    public Transform _attackPos;
    [SerializeField] public float _attackRange;
    [SerializeField] public LayerMask _checkEnemy;
    public int Damage;


    private void Update()
    {
        if (_timeBtwAttack <= 0)
        {
            if(Input.GetKey(KeyCode.G))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(_attackPos.position, _attackRange, _checkEnemy);
                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyController>().TakeDamage(Damage);
                }
            }
            _timeBtwAttack = _startBtwAttack;
        }
        else
        {
            _timeBtwAttack -= Time.deltaTime;
        }
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_attackPos.position, _attackRange);
        Debug.Log("Yes");
    }
}
