using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectInRoom : MonoBehaviour
{
    private PositionSpawn _obj;
    public PositionSpawn[] Objs;
    public Room Room;

    private void Start()
    {
        for(int i=0; i<6; i++)
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        _obj = Instantiate(Objs[Random.Range(0, Objs.Length)]);
        _obj.SetPosition(Room.End.position.y, Room.Begin.position.y);
        _obj.transform.parent = Room.transform;
    }
}
