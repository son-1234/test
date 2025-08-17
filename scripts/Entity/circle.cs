using UnityEngine;

public class circle : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speedX = 10; // 속도 설정

    [SerializeField] private float speedY = 10; // 속도 설정

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(speedX, speedY); // Rigidbody2D의 속도를 설정
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
