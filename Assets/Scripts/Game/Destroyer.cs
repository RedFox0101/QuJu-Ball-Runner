using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    private SpawnRoom _spawnRoom;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EndRoom room))
        {
            _spawnRoom.Spawn();
            Destroy(room.transform.parent.gameObject, 1f);
        }
    }
}
