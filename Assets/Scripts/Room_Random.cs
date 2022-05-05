using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Random : MonoBehaviour
{

    [SerializeField]
    private List<Transform> _positionSpawn;
    
    [SerializeField]
    private GameObject[] _spawnPlatform;
    [SerializeField]
    private int _countPlatform;
    private void Start()
    {
        int buff;
        for (int i = 0; i < _countPlatform; i++)
        {
            
            
            buff = Random.Range(0, _positionSpawn.Count);
          
            Instantiate(_spawnPlatform[Random.Range(0, _spawnPlatform.Length)], _positionSpawn[buff].position, Quaternion.identity);
            
            _positionSpawn.RemoveAt(buff);
          
        }
    }
}
