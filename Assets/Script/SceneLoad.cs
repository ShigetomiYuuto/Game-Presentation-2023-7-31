using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        ScoreManager._score = 0f;
        SceneManager.LoadScene(sceneName); //string sceneNameにすることでいろんな場面でこれを使えるようにする。
    }

    public void CloseGame()
    {
        ScoreManager._score = 0f;
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        return;
#else
        Application.Quit();
#endif
    }
}
