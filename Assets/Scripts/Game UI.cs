using UnityEngine;
using System;

public class GameUI : MonoBehaviour
{
    public GameObject menu;
    public GameObject quitButton;
    public static event Action onStartGame;

    void Start()
    {
        if (menu != null)
        {
            menu.SetActive(true);
            Debug.Log("Menu aktif saat Start()");
        }
        else
        {
            Debug.Log("Objek Menu tidak terhubung!");
        }
    }

    public void OnStartGameButtonClicked()
    {
        Debug.Log("Start Button diklik!"); // Tambahkan debugging di sini
        if (menu != null)
        {
            menu.SetActive(false);
            Debug.Log("Menu dinonaktifkan!");
        }
        else
        {
            Debug.Log("Objek Menu tidak terhubung!");
        }
        onStartGame?.Invoke();
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }

    private void CheckDisableQuitButton()
    {
#if UNITY_WEBGL
        quitButton.SetActive(false);
#endif
    }
}