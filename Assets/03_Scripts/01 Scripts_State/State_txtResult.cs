using UnityEngine;
using System.Collections;
using UnityEditorInternal;

/// <summary>
/// 상태를 결정하는 스크립트
/// 단순한 형태의 이벤트를 전달받으면, 현재의 종합적인 환경을 판단하여 상태를 결정하고 반영한다. 
/// TV를 예로 들면 채널 버튼을 누르는 이벤트는 동일하지만 메뉴가 띄워져있는 상태인지, 아닌 상태인지에 따라서 다른 상태로 전환이 이루어진다. 어떤 환경인지에 대한 판단을 하기 스크립트에서 수행한다.
/// </summary>
//enum States : byte
//{
//	Idle = 0, Test1, Test2, Test1And2
//}

//enum Requests : byte
//{
//	Idle = 0, Test1, Test2, Test1And2
//}

public class State_txtResult : MonoBehaviour
{
	// 오브젝트의 상태 값
	private string stateValue;

	public string StateValue
	{
		get
		{
			return stateValue;
		}

		set
		{
			switch (value)
			{
				case "Idle":
					stateValue = "Idle";
					break;
				case "Test1":
					stateValue = "Test1";
					break;
				case "Test2":
					stateValue = "Test2";
					break;
				case "Test1+Test2":
					stateValue = "Test1+Test2";
					break;
			}
			stateValue = value;
		}
	}

	void Awake()
	{
		StateValue = "Idle";
	}

}
