using UnityEngine;

public class circle : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speedX = 10; // 속도 설정
    [SerializeField] private float speedY = 10; // 속도 설정
    //공이 생성되는 최댓값과 최솟값 지정 나중에 Inspector에서 조정 가능
    [SerializeField] private float minX = -10;
    [SerializeField] private float maxX = 10;
    [SerializeField] private float minY = -10;
    [SerializeField] private float maxY = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(speedX, speedY);
        CircleSpawn(); // Rigidbody2D의 속도를 설정
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float CircleSpawn()
    {
        
        float RandomX = Random.Range(minX, maxX);
        float RandomY = Random.Range(minY, maxY);
        transform.position = new Vector2(RandomX, RandomY);
        return RandomX;
    }
}
    
