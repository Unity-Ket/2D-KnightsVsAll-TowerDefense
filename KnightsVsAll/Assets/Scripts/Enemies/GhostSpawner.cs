using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [Range(1f, 30f)] [SerializeField] float minSpawnDelay;
    [Range(1f, 60f)] [SerializeField] float maxSpawnDelay;
    [SerializeField] GhostAttacker[] ghostsPrefabs;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            spawnEnemy();
        }
    }

    public void stopSpawning()
    {
        spawn = false;
    }


    private void spawnEnemy()
    {
        var ghostAttackerArrayIndex = Random.Range(0, ghostsPrefabs.Length);
        Spawn(ghostsPrefabs[ghostAttackerArrayIndex]);
    }

    private void Spawn(GhostAttacker myGhost)
    {
        GhostAttacker newGhost = Instantiate(myGhost, transform.position, transform.rotation) as GhostAttacker;
        newGhost.transform.parent = transform;


    }
}
