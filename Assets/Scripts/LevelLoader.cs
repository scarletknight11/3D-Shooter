using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public void Level(string level)
    {
          SceneManager.LoadScene(level);
    }
   
}
