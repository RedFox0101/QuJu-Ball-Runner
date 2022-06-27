using System.Collections.Generic;
using UnityEngine;

public class SpawnerBonus : MonoBehaviour
{
    [SerializeField] private List<GameObject> _bonus;
    [SerializeField] private int _changeSpawn;

    private void OnEnable()
    {
        Spawn();
    }

    private void Spawn()
    {
        int random = Random.Range(0, 100);

        if (random < _changeSpawn)
        {
            var bonusPrefab = _bonus[Random.Range(0, _bonus.Count)];
            var bonus = Instantiate(bonusPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
