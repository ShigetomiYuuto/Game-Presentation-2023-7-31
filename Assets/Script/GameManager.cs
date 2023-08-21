using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int _score;
    [SerializeField] Text _scoreText = null;

    void Start()
    {
        AddScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        _score += score;
        if (_scoreText)
        {
            _scoreText.text = "Score: " + _score.ToString("d8");
        }
    }
}
