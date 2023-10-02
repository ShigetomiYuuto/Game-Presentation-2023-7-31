using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ScoreManager : MonoBehaviour
{
    public static float _score;
    [SerializeField] Text _scoreText = default;
    [SerializeField] float _scoreChangeInterval = 0.5f;

    void Start()
    {
        AddScore(0);
    }

    public void AddScore(float score)
    {
        DOTween.To(() => _score,newValue => 
        _scoreText.text = "Score:" + newValue.ToString("00000000"),_score + score, _scoreChangeInterval).OnComplete(() => _score += score);

        //_score += score;
        //if (_scoreText)
        //{
        //    _scoreText.text = "Score: " + _score.ToString("d8");
        //}
    }
}
