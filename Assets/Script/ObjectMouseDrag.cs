using UnityEngine;

public class ObjectMouseDrag : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()//�}�E�X�ŃQ�[���I�u�W�F�N�g���N���b�N�����Ƃ��ɌĂяo����郁�\�b�h
    {
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()//�}�E�X�ŃQ�[���I�u�W�F�N�g���h���b�O���Ă���Ƃ��ɌĂяo�����Ƃ��ɌĂ΂�郁�\�b�h
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    private Vector3 GetMouseWorldPos()//�}�E�X�J�[�\���̍��W���X�N���[�����W���烏�[���h���W�ɕϊ����郁�\�b�h
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}