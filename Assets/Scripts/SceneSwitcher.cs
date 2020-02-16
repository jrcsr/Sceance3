using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class SceneSwitcher : MonoBehaviour
{
    [UsedImplicitly]

    public void OnClick(){ Debug.Log("test"); SceneManager.LoadScene("Scene2");}
}
