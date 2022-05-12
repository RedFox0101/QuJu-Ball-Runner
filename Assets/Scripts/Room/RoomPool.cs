using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoomPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;

    private List<Room> _pool = new List<Room>();

    protected void Initialize(Room[] rooms)
    {
        foreach (var room in rooms)
        {
            var spawned = Instantiate(room, _container.transform);
            spawned.gameObject.SetActive(false);
            _pool.Add(spawned);
        }
    }

    protected Room GetRoom()
    {
        var hiddenRoom= _pool.Where(room => room.gameObject.activeSelf == false).ToList();

        return hiddenRoom[Random.Range(0, hiddenRoom.Count)];
    }
}
