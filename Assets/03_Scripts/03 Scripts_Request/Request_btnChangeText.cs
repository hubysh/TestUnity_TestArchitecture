using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// 오브젝트의 상태 변화를 요청하는 컴포넌트
/// 어떤 환경에서 요청하는지에 따라 요청하는 내용이 달라진다. 
/// 특정 이벤트가 발생하면, 이 이벤트를 환경을 고려하여 어떠한 요청으로 해석할지 하기 코드에서 판단한다. 
/// </summary>
public class Request_btnChangeText: MonoBehaviour
{
	void RequestChangeState()
	{

	}
	void RequestChangeStateText1()
	{
		Singleton.Instance.txtResult_State.StateValue = "Test1";
		Debug.Log("Complete Request : " + Singleton.Instance.txtResult_State.StateValue);
	}

	void RequestChangeStateText2()
	{
		Singleton.Instance.txtResult_State.StateValue = "Test2";
		Debug.Log("Complete Request : " + Singleton.Instance.txtResult_State.StateValue);
	}
	void RequestChangeStateText1And2()
	{
		Singleton.Instance.txtResult_State.StateValue = "Test3";
		Debug.Log("Complete Request : " + Singleton.Instance.txtResult_State.StateValue);
	}

}
