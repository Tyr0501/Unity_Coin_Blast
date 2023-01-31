using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMiniBoss : MonoBehaviour
{
    [SerializeField] List<GameObject> _listEnemy;
    int _lineEnemyMiniBoss;
    EnemyManager myEnemyManager;
    GroupEnemys myGroupEnemys;
    bool _isPlayGame = true;
    private void Awake()
    {
        myEnemyManager = FindObjectOfType<EnemyManager>();
        _lineEnemyMiniBoss = myEnemyManager.GetLineEnemyMiniBoss();
        myGroupEnemys = FindObjectOfType<GroupEnemys>();
    }
    void LossOfLife()
    {
        _lineEnemyMiniBoss -= 1;
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            LossOfLife();
            Destroy(other.gameObject);
        }
    }


    public int GetLineThisMiniBoss()
    {
        return _lineEnemyMiniBoss;
    }
}
