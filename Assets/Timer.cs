using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerLabel;
    [SerializeField]
    private int _coulDawn;
    public bool IsPlay=false;
    

    private void Start()
    {
        TimerLabel =this.GetComponent<Text>();
    }
    public void PlayTimer()
    {
        StartCoroutine(OnTimer());
    }

    IEnumerator OnTimer()
    {
        while (_coulDawn != -1)
        {
            if (_coulDawn == 0)
            {
                TimerLabel.text = "Go";
            }
            else
            {
                TimerLabel.text = Convert.ToString(_coulDawn);
            }
           
            _coulDawn--;
            yield return new WaitForSecondsRealtime(1);
        }

        if (_coulDawn ==-1)
        {

            Time.timeScale = 1;
            _coulDawn = 3;
            TimerLabel.gameObject.SetActive(false);

        }
    }
}
