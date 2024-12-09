using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void LoadRoom(string roomName)
    {
        SceneManager.LoadScene(roomName);
    }
}