using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecordName : MonoBehaviour
{
    public Text welcome;
    public Text newName;
    public static RecordName Instance;
    public string playerName;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GetText(string name)
    {
        newName.text = name;
        Debug.Log(newName.text);
        welcome.text = $"Welcome {newName.text}";
        RecordName.Instance.playerName = newName.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

}
