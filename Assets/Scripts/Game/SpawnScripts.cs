using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnScripts : MonoBehaviour
{
    private Room _newRoom;
    private Room _installedRooms;
    public Room[] Rooms;
    private void Start()
    {
        _newRoom = Instantiate(Rooms[Random.Range(0, Rooms.Length)]);
        _newRoom.transform.position = new Vector2(0f, -1f);
        _installedRooms = _newRoom;
        Spawn();
        Spawn();
    }

    public void Spawn()
    {
        _newRoom = Instantiate(Rooms[Random.Range(0, Rooms.Length)]);
        _newRoom.transform.position = _installedRooms.End.position - _newRoom.Begin.localPosition;
        _installedRooms=_newRoom;
    }

    

  
}




