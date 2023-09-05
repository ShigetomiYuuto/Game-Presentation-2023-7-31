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
    void OnMouseDown()//マウスでゲームオブジェクトをクリックしたときに呼び出されるメソッド   参考元　https://soft-rime.com/post-11206/
    {
        offset = gameObject.transform.position - GetMouseWorldPos();
        _gravity = _rb.gravityScale;
        _rb.gravityScale = 0;
    }

    void OnMouseDrag()//マウスでゲームオブジェクトをドラッグしているときに呼び出されるときに呼ばれるメソッド
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    private void OnMouseUp()
    {
        transform.position = GetMouseWorldPos() + offset;
        _rb.gravityScale = _gravity;
    }

    private Vector3 GetMouseWorldPos()//マウスカーソルの座標をスクリーン座標からワールド座標に変換するメソッド
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}