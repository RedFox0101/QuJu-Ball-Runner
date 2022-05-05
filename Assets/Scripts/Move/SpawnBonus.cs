using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> Bonus;

    private void Start()
    {
        if (Random.Range(0, 10) == 5)
        {
            var bonus = Instantiate(Bonus[Random.Range(0, Bonus.Count)], transform.position, Quaternion.identity);
            bonus.transform.parent = this.transform;
        }
    }
}
