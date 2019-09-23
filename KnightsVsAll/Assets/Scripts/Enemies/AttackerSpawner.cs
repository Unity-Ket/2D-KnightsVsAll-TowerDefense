using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [Range(0f, 30f)] [SerializeField] float minSpawnDelay;
    [Range(0f, 60f)] [SerializeField] float maxSpawnDelay;
    [SerializeField] Attacker [] attackerPrefabArray;

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
        var attackerArrayIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerArrayIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;

        newAttacker.transform.parent = transform;
    }

}//AtackerSpawner
