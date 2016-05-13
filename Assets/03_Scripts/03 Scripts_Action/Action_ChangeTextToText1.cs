using UnityEngine;
using System.Collections;

public class Action_ChangeTextToText1 : MonoBehaviour
{
	void ChangeTextToText1()
	{
		Singleton.Instance.txtResult_Text.text = "Changed Text1";
	}
}
