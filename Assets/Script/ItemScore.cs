using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScore : MonoBehaviour
{
    [SerializeField] int _score = 1000;
    [SerializeField] AudioClip _sound1;
    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _audioSource.PlayOneShot(_sound1);
            ScoreManager s = ScoreManager.FindObjectOfType<ScoreManager>();
            if (s)
            {
                s.AddScore(_score);
            }

            Destroy(this.gameObject);
        }
    }
}
