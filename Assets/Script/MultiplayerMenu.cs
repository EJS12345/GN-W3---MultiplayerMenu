using UnityEngine;
using Unity.Netcode;

public class MultiplayerMenu : NetworkBehaviour
{
    [Header("UI Reference")]
    public GameObject menuCanvas;

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        HideUI();
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        HideUI();
    }

    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        HideUI();
    }

    private void HideUI()
    {
        // Disables the Canvas containing the buttons
        if (menuCanvas != null)
        {
            menuCanvas.SetActive(false);
        }
    }
}