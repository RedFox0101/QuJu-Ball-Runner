using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdPlatform : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _platform;
    [SerializeField]
    private Transform[] _posSpawn;
    private void Start()
    {
       

        for(int i=0; i<2; i++)
        {
            Instantiate(_platform[Random.Range(0, _platform.Length)], _posSpawn[Random.Range(0, _posSpawn.Length)].position, Quaternion.identity);
        }
    }
}
