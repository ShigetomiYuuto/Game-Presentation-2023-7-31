using UnityEngine;

public class ObjectMouseDrag : MonoBehaviour
{
    private Vector3 _offset;
    private Vector2 _startPos;
    private Rigidbody2D _rb;
    private float _gravity = 0f;
    private Collider2D _collider;
    bool _isDragging = true;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    void OnMouseDown()//�}�E�X�ŃQ�[���I�u�W�F�N�g���N���b�N�����Ƃ��ɌĂяo����郁�\�b�h   �Q�l���@https://soft-rime.com/post-11206/
    {
        _offset = gameObject.transform.position - GetMouseWorldPos();
        _gravity = _rb.gravityScale;
        _rb.gravityScale = 0;
        _collider.isTrigger = true;
        _startPos = transform.position;
    }

    void OnMouseDrag()//�}�E�X�ŃQ�[���I�u�W�F�N�g���h���b�O���Ă���Ƃ��ɌĂяo�����Ƃ��ɌĂ΂�郁�\�b�h
    {
        transform.position = GetMouseWorldPos() + _offset;
    }

    private void OnMouseUp()
    {
        transform.position = GetMouseWorldPos() + _offset;
        _rb.gravityScale = _gravity;
        _collider.isTrigger = false;
        if (!_isDragging )
        {
            transform.position = _startPos;
            _isDragging = true;
        }
    }

    private Vector3 GetMouseWorldPos()//�}�E�X�J�[�\���̍��W���X�N���[�����W���烏�[���h���W�ɕϊ����郁�\�b�h
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayArea")
        {
            _isDragging = false;
            Debug.Log("�o��");
        }
    }
}