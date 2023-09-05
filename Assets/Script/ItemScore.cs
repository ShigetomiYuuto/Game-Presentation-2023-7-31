using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScore : MonoBehaviour
{
    [SerializeField] int _score = 1000;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager s = GameManager.FindObjectOfType<GameManager>();
            if (s)
            {
                s.AddScore(_score);
            }

            Destroy(this.gameObject);
        }
    }
}
