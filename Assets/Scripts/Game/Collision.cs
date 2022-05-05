using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField]
    private SpawnScripts _spawnObject;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.tag == "Room_Begin")
        {
            
            _spawnObject.Spawn();
           
            Destroy(collision.transform.parent.gameObject, 0.2f);
            Debug.Log("Destroy Room");
        }
    }
}
