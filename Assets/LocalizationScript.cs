using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationScript : MonoBehaviour {
	[SerializeField] string _ru;
	[SerializeField] string _en;
	
	void Start () {
		if (LanguageManager.Instance.CurrentLanguage == "ru")
		{
			GetComponent<Text>().text = _ru;
		}
		else if (LanguageManager.Instance.CurrentLanguage == "en")
		{
			GetComponent<Text>().text = _en;
		}
		else
		{
			GetComponent<Text>().text = _en;
		}
	}
}
