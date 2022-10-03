using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoll : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform);
            yield return new WaitForSeconds(spawnTimer);
        }
    }

    
}
