using UnityEngine;

public class SpawnRoom : RoomPool
{
    [SerializeField] private Room[] _rooms;

    private Room _newRoom;
    private Room _installedRooms;

    private void Start()
    {
        Initialize(_rooms);

        _newRoom = GetRoom();
        _newRoom.transform.position = new Vector2(0, 1f);
        _newRoom.gameObject.SetActive(true);
        _installedRooms = _newRoom;
        Spawn();
        Spawn();
    }

    public void Spawn()
    {
        _newRoom = GetRoom();
        _newRoom.gameObject.SetActive(true);
        _newRoom.transform.position = _installedRooms.End.position - _newRoom.Begin.localPosition;
        _installedRooms = _newRoom;
    }

}




