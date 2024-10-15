using UnityEngine;

public class Distance : MonoBehaviour
{
    /// <summary>
    /// Vector3 Distance 함수
    /// - 두 점 사이의 거리를 계산하는데 사용되는 함수
    /// - Vector3 타입의 두점을 입력 받고 두점 사이의 직선 
    /// 거리를 float 형태로 반환
    /// - 이 함수의 계산 방식은 유클리드 거리 공식을 기반
    /// 
    /// 사용목적
    /// Vector3.Distance 함수는 게임 개발에서 매우 중요한 역할을 한다.
    /// 특히 두 객체간 거리를 판단해 특정 이벤트를 트리거 하는데 사용된다. 
    /// </summary>
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 2f, 0f);
        Vector3 v2 = new Vector3(5f, 7f, 0f);

        // 두 벡터 v1, v2 사이의 거리
        Debug.Log("Distance of v1, v2 = " + Vector3.Distance(v1, v2));
    }
}
