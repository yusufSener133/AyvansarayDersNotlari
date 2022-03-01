using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class TreeSpawner : BaseSpawner
{
    [SerializeField] EnemyController[] _enemy;
    protected override void EnemySpawner()
    {
        Instantiate(_enemy[Random.Range(0, _enemy.Length)], this.transform.position, this.transform.rotation, this.transform);
    }
}
