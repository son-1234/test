using UnityEngine;

public class circle : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 10; // 속도 설정
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CircleMove(Vector2.left);
    }
    /* I는 이동 방향을 나타내는 벡터
             speed는 이동 속도
             rb는 Rigidbody2D 컴포넌트로, 물리 기반의 이동을 처리
             linearVelocity를 사용하여 Rigidbody2D의 속도를 설정.*/ 
    private void CircleMove(Vector2 I)
        
    {
        rb.linearVelocity = speed * I; // Rigidbody2D를 사용하여 위치 이동
    }
}
