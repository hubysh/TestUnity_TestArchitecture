using UnityEngine;
using System.Collections;
using UnityEditorInternal;

/// <summary>
/// 오브젝트의 상태를 결정하는 스크립트
/// 정해진 형태로 상태 변화를 요청받으면, 현재의 종합적인 환경을 판단하여 최종 상태를 결정하고 반영한다. 
/// </summary>

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
