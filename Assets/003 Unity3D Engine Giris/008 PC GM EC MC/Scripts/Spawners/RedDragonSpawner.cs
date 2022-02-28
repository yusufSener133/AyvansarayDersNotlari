using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class RedDragonSpawner : BaseSpawner
{
    [SerializeField] EnemyController _Enemy;
    protected override void EnemySpawner()
    {
        Instantiate(_Enemy, new Vector3(this.transform.position.x,Random.Range(this.transform.position.y-2, this.transform.position.y+2)), this.transform.rotation, this.transform);
    }
}
