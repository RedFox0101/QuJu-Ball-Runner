using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
    [SerializeField] private int _sceneId;

    public void onLoadScene()
    {
        SceneManager.LoadScene(_sceneId);
    }

}
