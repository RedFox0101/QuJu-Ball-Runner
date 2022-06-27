using UnityEngine;

public class SwitchRooms : MonoBehaviour
{
    [SerializeField]
    private SpawnRoom _spawnRoom;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EndRoom endRoom))
        {
            _spawnRoom.Spawn();
            var room = endRoom.transform.parent.gameObject;
            room.SetActive(false);
            room.transform.position = Vector3.zero;
        }
    }
}
