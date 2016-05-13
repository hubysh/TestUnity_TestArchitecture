using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// 상태 변화를 요청하는 컴포넌트
/// 스크립트의 이름은 어떠한 상태로 변하기를 원하는지 나타내야 한다.
/// 하기 클래스는 오브젝트의 내용이 "Text1"로 바뀌도록 상태변화를 요청할 것이므로, 이 내용을 담은 클래스 이름이 되어야한다.
/// </summary>
public class Request_ChangeStateToTxtResult : MonoBehaviour
{
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
