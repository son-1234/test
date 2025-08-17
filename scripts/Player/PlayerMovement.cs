using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once  before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rb;
    [SerializeField]private float speed = 4;//serializefield를 사용하면 private를 해도 inspector에서 값을 조정할 수 있다.
    [SerializeField] private GameObject PlayerSpawn;

    [SerializeField] private float leftlimit = -3;
    [SerializeField] private float rightlimit = 3;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = PlayerSpawn.transform.position;//게임시작시 플레이어 스폰위치로 옮겨짐.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* FixedUpdate는 기본 0.02초 마다 50프레임 마다 불러옴
    * 기능은 Update함수와 동
    * 그래서 성능이 안좋든 좋든 똑같은 프레임으로 플레이가능
    * 만약 fps나 게임 프레임을 높이려면 무조건 Update함수로 작성해야함
    */ 
    private void FixedUpdate()
    {
        Vector2 playerposition = transform.position;

        if (playerposition.x > rightlimit)
        {
            playerposition.x = rightlimit;// 플레이어가 오른쪽 한계선을 넘어가지 않도록 제한
        }
        else if (playerposition.x < leftlimit)
        {
            playerposition.x = leftlimit; // 플레이어가 왼쪽 한계선을 넘어가지 않도록 제한
        }

        transform.position = playerposition;
    }

    public void OnMove(InputValue inputValue)
    {
        float input = inputValue.Get<Vector2>().x;
        //Debug.Log("Key:"+input);
        if (Mathf.Abs(input)>0)
        {
            rb.linearVelocity = input * Vector2.right * speed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
