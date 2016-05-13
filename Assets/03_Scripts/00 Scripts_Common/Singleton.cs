using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

/// <summary>
/// 전역에서 접근 가능한 클래스
/// MonoBehaviour을 상속한 이유는 Inspetor에서 정보를 실시간으로 보기 위함
/// 상속 없을 경우, 객체 핸들 얻지 못함.
/// </summary>
public class Singleton : MonoBehaviour
{
	// 정적 Singleton 객체 생성
	private static Singleton instance = null;

	// 게임오브젝트 핸들 변수
	public GameObject txtResult;

	// 게임오브젝트 내 컴포넌트 핸들 변수
	public State_txtResult txtResult_State;		

	public static Singleton Instance
	{
		get
		{
			if (instance == null)
			{
				GameObject objSingleton = new GameObject("objSingleton");
				instance = objSingleton.AddComponent(typeof(Singleton)) as Singleton;
			}
			return instance;
		}
	}

	void Awake()
	{
		// 게임오브젝트 얻기
		txtResult = GameObject.Find("txtResult");

		// 상태 컴포넌트 얻기
		txtResult_State = txtResult.GetComponent<State_txtResult>();
	}

}