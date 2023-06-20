using UnityEngine;

public class Triangle : MonoBehaviour
{
    private Rigidbody rigidBody;
    private Mesh mesh;

    void Start()
    {
        // 获取物体的Rigidbody组件，用于添加物理效果
        rigidBody = GetComponent<Rigidbody>();

        // 创建一个新的Mesh，包含三个顶点和一个三角形面
        mesh = new Mesh();
        Vector3[] vertices = new Vector3[3];
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(1, 0, 0);
        vertices[2] = new Vector3(0, 1, 0);
        mesh.vertices = vertices;
        mesh.triangles = new int[] {0, 1, 2};
        mesh.RecalculateNormals();

        // 将Mesh赋值给Mesh Filter组件
        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        // 添加一个材质并赋值给Mesh Renderer组件
        Material material = new Material(Shader.Find("Standard"));
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;
    }

    void Update()
    {
        // 可以在Update方法中添加移动控制等操作，例如：
        float speed = 5.0f;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rigidBody.AddForce(movement * speed);
    }
}