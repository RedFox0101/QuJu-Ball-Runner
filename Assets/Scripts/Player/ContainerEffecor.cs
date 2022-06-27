using UnityEngine;

public class ContainerEffecor : MonoBehaviour
{
    [SerializeField] private CustomPointerEffector _pointEffector;

    public void StartEffect()
    {
        _pointEffector.gameObject.SetActive(true);
    }

    public void StopEffect()
    {
        _pointEffector.gameObject.SetActive(false);
    }
}
