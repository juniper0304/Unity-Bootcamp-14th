using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5; //할당, 초기화
        rb = GetComponent<Rigidbody>();
        //GetComponent<T>(): 게임 오브젝트에 붙어있는 컴포넌트를
        //가져오는 기능이다.
        //T : Type
        Debug.Log("설정이 완료되었습니다.");
    }

    // Update is called once per frame
    void Update()
    {
        //speed += 1;
        //Debug.Log($"속도가 1 증가합니다. 현재 속도는 {speed}입니다.");

        //수평이동
        float horizontal = Input.GetAxis("Horizontal");
        
        //수직이동
        float vertical = Input.GetAxis("Vertical");

        //이동좌표(벡터) 설정
        Vector3 movement= new Vector3 (horizontal, 0, 
           vertical);

        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    { if (other.gameObject.CompareTag("Item Box"))
        {other.gameObject.SetActive(false);} //충돌체의 게임오브젝트를 비활성화
        Debug.Log("아이템을 획득하셨습니다.");

        if (other.gameObject.CompareTag("Obstacle"))
            Destroy("Obstacle");
        
        speed += -1;


     }
    
}
