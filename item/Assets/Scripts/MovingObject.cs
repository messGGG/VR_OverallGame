using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float leftLimit ;
    public float rightLimit;

    private bool moveRight = true;

    void Update()
    {
        // 如果物体到达左边的限制，则让它向右移动
        if (transform.position.x <= leftLimit)
            moveRight = true;
        // 如果物体到达右边的限制，则让它向左移动
        if (transform.position.x >= rightLimit)
            moveRight = false;

        // 根据移动方向和速度移动物体
        if (moveRight)
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        else
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    }
}