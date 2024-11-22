using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LanguageManager : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern string GetLang();

    // ru en
    public string CurrentLanguage;

    public static LanguageManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            CurrentLanguage = GetLang();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
