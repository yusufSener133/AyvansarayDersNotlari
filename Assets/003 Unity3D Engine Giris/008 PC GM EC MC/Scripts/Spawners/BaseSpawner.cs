using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    //[SerializeField] EnemyController[] _Enemy; //prefabdan cagirmak icin
    // EnemyController iceren dosyalarin gelmesini istedigimiz icin GameObject yazmadik.


    //[Range(int,int)] bu aralikta bir float sec.
    [Range(0.1f, 5)] [SerializeField] float _minSpawnTime; // Spawn edilecek objenin min max suresi
    [Range(1, 6)] [SerializeField] float _maxSpawnTime;
    float _randomSpawnTime, _currentTime;


    void Start()
    {
        ResetTime();
    }
    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _randomSpawnTime)
        {
            //Obje Instantiate
            EnemySpawner();
            ResetTime();

        }
    }

    void ResetTime()
    {
        _currentTime = 0;
        _randomSpawnTime = Random.Range(_minSpawnTime, _maxSpawnTime);

    }

    protected abstract void EnemySpawner();
    
}

