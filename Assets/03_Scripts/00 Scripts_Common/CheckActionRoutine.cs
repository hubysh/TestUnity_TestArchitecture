using UnityEngine;
using System.Collections;

public class CheckActionRoutine : MonoBehaviour
{
	void ChangeTextToText1()
	{
		Singleton.Instance.txtResult_Text.text = "Changed Text1";
	}
}
