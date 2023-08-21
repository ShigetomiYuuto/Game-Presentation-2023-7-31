using UnityEngine;

public class ObjectMouseDrag : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()//マウスでゲームオブジェクトをクリックしたときに呼び出されるメソッド
    {
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()//マウスでゲームオブジェクトをドラッグしているときに呼び出されるときに呼ばれるメソッド
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    private Vector3 GetMouseWorldPos()//マウスカーソルの座標をスクリーン座標からワールド座標に変換するメソッド
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}