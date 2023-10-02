using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] float _fallingTime = 0f;
    [SerializeField] float _desTime = 0f;
    private float _time = 0f;
    //private float _normalgravity = 0f;
    //private float _gravity = 0f;
    private Rigidbody2D _rb;
    private Vector2 _strarPos;

    void Start()
    {
        //_normalgravity = _rb.gravityScale;
        _rb = GetComponent<Rigidbody2D>();
        _strarPos = transform.position;
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroundDiscrimination")
        {
            _time += Time.deltaTime;
            Debug.Log("Ab");
            if (_time < _fallingTime)
            {
                Debug.Log("A");
                _rb.gravityScale = 1;
                _time = 0f;
                Instantiate(gameObject, _strarPos, Quaternion.identity);
                Destroy(this.gameObject, _desTime);
            }
        }
    }
}
