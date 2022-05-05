using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLoad : MonoBehaviour
{
   
    public int SceneNumber;
   
  


    public void onLoadScene()
    {
      
        SceneManager.LoadScene(SceneNumber);
    }

   

  
}
