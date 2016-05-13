using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using System;

/// <summary>
/// 오브젝트의 상태를 결정하는 스크립트
/// 정해진 형태로 상태 변화를 요청받으면, 현재의 종합적인 환경을 판단하여 최종 상태를 결정하고 반영한다. 
/// </summary>

public class State_txtResult : MonoBehaviour
{
	// 오브젝트의 상태 값
	private string stateValue;
	private string tempStateValue;

	public string StateValue
	{
		get
		{
			return stateValue;
		}

		set
		{
			tempStateValue = stateValue;

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

			if (tempStateValue != stateValue)
			{
				Act();
			}
		}

		
	}

	// Act 함수는 이벤트함수 배열로 작성
	private void Act()
	{
		// 조건에 따라 실행되는 컴포넌트의 조합이 달라진다. 
	}

	void Awake()
	{
		StateValue = "Idle";
	}



}
