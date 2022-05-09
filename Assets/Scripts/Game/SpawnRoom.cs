using UnityEngine;

public class SpawnRoom : MonoBehaviour
{
    [SerializeField] private Room[] Rooms;

    private Room _newRoom;
    private Room _installedRooms;

    private void Start()
    {
        _newRoom = Instantiate(Rooms[Random.Range(0, Rooms.Length)]);
        _newRoom.transform.position = new Vector2(0, 1f);
        _installedRooms = _newRoom;
        Spawn();
        Spawn();
    }

    private void InitializeSpawn()
    {
        Spawn();
        _newRoom.transform.position = new Vector2(0f, 1f);
        Spawn();
        Spawn();
    }

    public void Spawn()
    {
        _newRoom = Instantiate(Rooms[Random.Range(0, Rooms.Length)]);
        _newRoom.transform.position = _installedRooms.End.position - _newRoom.Begin.localPosition;
        _installedRooms = _newRoom;
    }




}




