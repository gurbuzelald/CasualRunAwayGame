using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : AbstractSceneController<SceneController>
{
    public string CheckSceneName()
    {
        string _sceneName = SceneManager.GetActiveScene().name;
        return _sceneName;
    }

    public enum Scenes
    {
        Menu, End, Win, Game
    }
}
