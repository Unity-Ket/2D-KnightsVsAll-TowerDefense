using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem1Spawner : MonoBehaviour
{
    [Range(5f,10f)][SerializeField] float minSpawnDelay;
    [Range(10f,20f)][SerializeField] float maxSpawnDelay;
    [SerializeField] Golem1 enemyType;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            spawnEnemy();
        }
    }

    private void spawnEnemy()
    {
        Instantiate(enemyType, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
