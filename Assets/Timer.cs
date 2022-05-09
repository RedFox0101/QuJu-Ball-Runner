using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Timer : MonoBehaviour
{
    [SerializeField] private Text TimerLabel;
    [SerializeField] private int _coulDawn;

    private void Start()
    {
        TimerLabel = GetComponent<Text>();
    }

    public void PlayTimer()
    {
        StartCoroutine(Play());
    }

    IEnumerator Play()
    {

        while (_coulDawn != -1)
        {
            if (_coulDawn == 0)
            {
                TimerLabel.text = "Go";
            }
            else
            {
                TimerLabel.text = _coulDawn.ToString();
            }

            _coulDawn--;
            yield return new WaitForSecondsRealtime(1);
        }

        if (_coulDawn == -1)
        {
            Time.timeScale = 1;
            _coulDawn = 3;
            TimerLabel.gameObject.SetActive(false);
        }
    }
}
