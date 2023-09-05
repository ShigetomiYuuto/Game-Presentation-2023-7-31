using UnityEngine;

public class ObjectMouseDrag : MonoBehaviour
{
    private Vector3 offset;
    private Rigidbody2D _rb;
    private float _gravity = 0f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void OnMouseDown()//�}�E�X�ŃQ�[���I�u�W�F�N�g���N���b�N�����Ƃ��ɌĂяo����郁�\�b�h   �Q�l���@https://soft-rime.com/post-11206/
    {
        offset = gameObject.transform.position - GetMouseWorldPos();
        _gravity = _rb.gravityScale;
        _rb.gravityScale = 0;
    }

    void OnMouseDrag()//�}�E�X�ŃQ�[���I�u�W�F�N�g���h���b�O���Ă���Ƃ��ɌĂяo�����Ƃ��ɌĂ΂�郁�\�b�h
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    private void OnMouseUp()
    {
        transform.position = GetMouseWorldPos() + offset;
        _rb.gravityScale = _gravity;
    }

    private Vector3 GetMouseWorldPos()//�}�E�X�J�[�\���̍��W���X�N���[�����W���烏�[���h���W�ɕϊ����郁�\�b�h
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}