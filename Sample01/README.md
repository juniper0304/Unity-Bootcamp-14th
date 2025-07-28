# Unity Bootcamp 14th
Unity Bootcamp 14th Project
# 제목 적는 기능(H1)
## H2
### H3
#### H4
##### H5
###### H6

아무 문장이나 작성해보면 이렇게 나옵니다.

```cs
using UnityEngine;
public class Sample : MonoBehaviour
{
  void Start()
  {
    Debug.Log("HELLO~");
  }
}
```

**프로젝트 3일차 움직임 작업 구현 완료**
~~Sample.fbx 파일 사용~~

> 인터넷에 쓰여있는 내용은 진짜다.
>> 인터넷은 늘 볼거리가 많다.
> 그렇지만 사람들은 늘 할게 없다고 외친다.
>
> Awake():
> //스크립트 로드 시 활성화되는 것. 
> OnEnable:
> //이벤트 연결과 직관되어 있으며, 해당 영역 한정 Coroutine 실행이 불가능해진다.
> Start:
> Awake와 비슷하게 값을 수행하는 위치로 존재하긴 하나 상황에 따라 할당되는 영역이 달라진다.
> Update:
> 프레임당 1회 실행. Start와 다르게 지속적으로 반복수행해야 역할에 의미가 생긴다.
> FixUpdate():
> 발생주기가 필요한 업데이트에서 사용, 예시를 들어 특정 행위에 대한 반응을 의미한다.
> LateUpdate():
> 후처리 작업. 프레임 상 가장 늦게 처리된다.
> OnPreCull(), OnWillRenderObject(), OnRenderObject(), OnPostRender(), OnRenderImage(), OnGUI(), OnDrawGizmos():
