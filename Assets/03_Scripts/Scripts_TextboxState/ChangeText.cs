using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
	string text = "Changed";

	void ChangeTextAction()
	{
		Singleton.Instance.txtResult_Text.text = text;
	}

	
}
