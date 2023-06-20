using UnityEngine;

public class LimitObjectPosition : MonoBehaviour
{
    public float minX;           // 最小X值
    public float maxX;           // 最大X值
    public float minY;           // 最小Y值
    public float maxY;           // 最大Y值

    private void LateUpdate()
    {
        // 获取物体的当前位置
        Vector3 pos = transform.position;

        // 将位置限制在指定的矩形范围内
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        // 更新物体的位置
        transform.position = pos;
    }
}