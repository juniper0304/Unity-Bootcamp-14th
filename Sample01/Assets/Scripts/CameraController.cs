using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    offset= transform.position- Player.transform.position;        
    }

    // Update is called once per frame

  
    //Update()에서 처리할 부분을 다 처리한 후에 호출되는 위치
    //카메라 작업에서 사용된다.
 
    
       private void  LateUpdate()
    {
        //카메라의 위치는 플레이어와 일정 거리를 유지
        transform.position=  Player.transform.position+offset;
    }
}
