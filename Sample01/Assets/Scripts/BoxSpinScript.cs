using UnityEngine;

public class BoxSpinScript : MonoBehaviour
{
    public Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(pos* Time.deltaTime);
        //���� �����Ӻ��� ���� �����ӱ��� �ɸ� �ð�
        //Update������ ���� ������ Ȱ��
        //transform.Rotate(Vector3 pos);
        //�ش� ��ǥ��ŭ ���� ������Ʈ�� ȸ����ŵ�ϴ�.
    }
}
