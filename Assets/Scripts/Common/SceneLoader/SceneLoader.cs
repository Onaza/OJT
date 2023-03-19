using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader instance = null;

    public static SceneLoader Instance
    {
        get { return instance; }
    }

    private Dictionary<Type, GameObject> container;

    private void Awake()
    {
        instance = this;

        container = new Dictionary<Type, GameObject>();
    }

    public void Add<T>(GameObject obj) where T : class
    {
        container.Add(typeof(T), obj);
    }

    public T Get<T>() where T : class
    {
        return container[typeof(T)].GetComponent<T>();
    }

    public void LoadAsyncScene(string sceneName, Action completedCallbak = null)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Camera.main.gameObject.SetActive(false);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        operation.allowSceneActivation = true;

        operation.completed += (oper)=>
        {
            SceneManager.MoveGameObjectToScene(this.gameObject, SceneManager.GetSceneByName(sceneName));
            SceneManager.UnloadSceneAsync(currentScene);
            completedCallbak?.Invoke();
        };

    }
}
