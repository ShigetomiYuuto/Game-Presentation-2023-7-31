using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScore : MonoBehaviour
{
    [SerializeField] int _score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
