using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    [SerializeField] Vector2 _moveInput;
    [SerializeField] float _jumpP;
    [SerializeField] bool _isGrounded = true;
    [SerializeField] GameObject _gameManager = null;
    public AudioClip _sound1;
    public AudioClip _sound2;
    Rigidbody2D _rb = default;
    AudioSource _audioSource;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (_isGrounded)
        {
            Move();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = true;
        }
    }

    void Move()
    {
        _rb.velocity = new Vector2(_moveInput.x * _moveSpeed, _rb.velocity.y);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump (InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (_isGrounded)
            {
                _rb.AddForce(Vector2.up * _jumpP, ForceMode2D.Impulse);
                _isGrounded = false;
                _audioSource.PlayOneShot(_sound1);
            }
        }
    }
    public void OnPause(InputAction.CallbackContext context)
    {
        _audioSource.PlayOneShot(_sound2);
        if (_gameManager.GetComponent<PausedManager>()._isPaused)
        {
            _gameManager.GetComponent<PausedManager>()._isPaused = false;
            Time.timeScale = 1;
            Debug.Log("a");

        }
        else
        {
            _gameManager.GetComponent<PausedManager>()._isPaused = true;
            Time.timeScale = 0;
            Debug.Log("b");
        }
    }
}
