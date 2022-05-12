using Zenject;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _scoreView;
    [SerializeField] Text _bestScore;
    [Inject] private ContainerPlayers _containerPlayers;

    private int _score=0;
    private Health _health;
    private bool _IsScore=true;

    private void Start()
    {
        _containerPlayers.TryGetPlayerComponent(ref _health);
        _health.Dead += Stop;
        _bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    private void Stop()
    {
        _IsScore = false;
        SaveScore();
    }

    private void FixedUpdate()
    {
        if (_IsScore == true)
        {
            _score++;
            _scoreView.text = _score.ToString();
        }
    }

    private void SaveScore()
    {
        if (_score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", _score);
        }
    }


}
