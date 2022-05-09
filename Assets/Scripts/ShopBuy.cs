using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopBuy : MonoBehaviour
{
    public GameObject AudioSource;
    public Image Icon;
    public Text NameLabel, SumLabel;
    public int SumCoins;
    public int IndexBall;
    public bool IsBought;
    public string Key;

    private void Start()
    {
      
    }
    public void OnBuyBall()
    {
       
          if(PlayerPrefs.GetInt("Coins")>=SumCoins|| IsBought == true)
        {
            PlayerPrefs.SetInt(Key, 1);
          
            if (IsBought == false)
            {
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - SumCoins);
               
                Instantiate(AudioSource);

            }
           
            PlayerPrefs.SetInt("BallIndex", IndexBall);
            SceneManager.LoadScene(2);
        }

           

        
    }
}
