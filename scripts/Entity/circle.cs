using UnityEngine;

public class circle : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speedX = 10; // 속도 설정
    [SerializeField] private float speedY = 10; // 속도 설정
    //공이 생성되는 최댓값과 최솟값 지정 나중에 Inspector에서 조정 가능
    // 속도 설정
    [SerializeField] private float minX = -10;
    [SerializeField] private float maxX = 10;
    [SerializeField] private float minY = -10;
    [SerializeField] private float maxY = 10;
    
    [SerializeField] private float bounce = 10; // 튕겨나가는 힘

    [SerializeField] private float minS = 5;//최소 사이즈
    [SerializeField] private float maxS = 10;//최대 사이즈
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // 자신의 콜라이더 가져오기
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Ball"), LayerMask.NameToLayer("Ball"));
        출처: https://wookeee.tistory.com/entry/Unity-유니티-IgnoreLayerCollision-특정-레이어-충돌-무시 [매일개발자:티스토리]
        
        float randomScale= Random.Range(minS, maxS)/10f;
        transform.localScale = new Vector3(randomScale, randomScale, 1f);
        
        CircleSpawn();
        rb.linearVelocity = new Vector2(speedX, speedY);
         // Rigidbody2D의 속도를 설정
        rb.gravityScale = 1; // 중력 적용
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float CircleSpawn()
    {
        
        float RandomX = (Random.value > 0.5f) ? maxX : minX;
        float RandomY = Random.Range(minY, maxY);
        if (RandomX < 0)
        {
            speedX = -speedX; // 음수값을 양수로 변환
        }
        transform.position = new Vector2(RandomX, RandomY);
        return RandomX;
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // 현재 속도 가져오기
        Vector2 velocity = rb.linearVelocity;

        // y축 속도가 bounce보다 작으면 튕겨오르는 힘을 줌
        if (velocity.y < bounce)
        {
            velocity.y = bounce;
            rb.linearVelocity = velocity;
        }
    }

}