using UnityEngine;

public class PausedManager : MonoBehaviour
{
    public bool _isPaused = false;
    [SerializeField] GameObject _pausedUI;

    void Start()
    {
        _pausedUI.SetActive(_isPaused);
    }

    void Update()
    {
        _pausedUI.SetActive(_isPaused);
    }
}
