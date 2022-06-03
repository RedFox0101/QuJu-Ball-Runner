using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private ContainerPlayers _collectionPlayers;
    [SerializeField] private Timer _timer;

    private Transform _transformPlayer;
    private float _offset = 0.5f;
    private bool _isSpawn;

    private void Start()
    {
        _timer.gameObject.SetActive(true);

        _timer.PlayTimer();

        Time.timeScale = 0;

        _collectionPlayers.TryGetPlayerComponent(ref _transformPlayer);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_isSpawn == true)
        {
            if (collision.TryGetComponent(out Platform platform))
            {
                Spaw(collision.transform);
            }
        }
    }

    private void Spaw(Transform _platformaTransform)
    {
        _isSpawn = false;

        _transformPlayer.parent = null;

        _transformPlayer.position = new Vector2(_platformaTransform.position.x + _offset, _platformaTransform.position.y + _offset);
    
    }

    public void OnSpawn()
    {
        _isSpawn = true;
    }
}



