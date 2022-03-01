using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class FireBallSpawner : MonoBehaviour
{
    [SerializeField] EnemyController _enemy;
    [SerializeField] GameObject _player;
    

    private void Update()
    {
        Spawner();
    }
    protected void Spawner()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_enemy, _player.transform.position, _player.transform.rotation, this.transform);
        }
    }

    
}
