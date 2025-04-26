using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject zombie;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnZombie());
    }
    private IEnumerator SpawnZombie()
    {
        GameObject zombieCopy = Instantiate(zombie);
        yield return null;
    }


}
