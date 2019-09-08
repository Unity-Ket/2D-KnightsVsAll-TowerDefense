using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [Range(5f, 10f)] [SerializeField] float minSpawnDelay;
    [Range(10f, 20f)] [SerializeField] float maxSpawnDelay;
    [SerializeField] Attacker enemyType;

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
        Attacker newAttacker = Instantiate(enemyType, transform.position, transform.rotation) as Attacker;

        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
