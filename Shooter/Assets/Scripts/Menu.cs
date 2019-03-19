using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField]
    private Button restart, exit;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        restart.onClick.AddListener(Restart);
		exit.onClick.AddListener(Exit);
    }

    private void Restart(){
        SceneManager.LoadScene("FirstLevel");
    }
    private void Exit(){
        Application.Quit();
    }

    private void OnDestroy() {
		restart.onClick.RemoveAllListeners();
        exit.onClick.RemoveAllListeners();
	}
}
