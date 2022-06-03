using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : MonoBehaviour
{
    [SerializeField] private List<GameObject> _bonus;
    [SerializeField] private float _coolDownSpawn;

    private float lastTime=0;

    private void Update()
    {
        if (lastTime >= _coolDownSpawn)
        {
            lastTime = 0;
            Spawn();
        }
        lastTime += Time.deltaTime;
    }

    private void Spawn()
    {
        var platforms = FindObjectsOfType<Platform>();
        var platform = platforms[Random.Range(0, platforms.Length)];
        var bonusPrefab = _bonus[Random.Range(0, _bonus.Count)];
        var bonus = Instantiate(bonusPrefab, platform.transform.position, Quaternion.identity, platform.transform);
    }
}
