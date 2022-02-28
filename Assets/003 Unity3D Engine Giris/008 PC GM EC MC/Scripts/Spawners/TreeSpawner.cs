using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class TreeSpawner : BaseSpawner
{
    [SerializeField] EnemyController[] _Enemy;
    protected override void EnemySpawner()
    {
        Instantiate(_Enemy[Random.Range(0, _Enemy.Length)], this.transform.position, this.transform.rotation, this.transform);
    }
}
