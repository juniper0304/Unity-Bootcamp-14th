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

  
    //Update()���� ó���� �κ��� �� ó���� �Ŀ� ȣ��Ǵ� ��ġ
    //ī�޶� �۾����� ���ȴ�.
 
    
       private void  LateUpdate()
    {
        //ī�޶��� ��ġ�� �÷��̾�� ���� �Ÿ��� ����
        transform.position=  Player.transform.position+offset;
    }
}
