using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    public List<GameObject> gameObjects;
    [SerializeField] private Transform parentListObj;
    private int countObj;
    private bool canCheck = true;
    public void Start()
    {
        canCheck = true;
        foreach (Transform tr in parentListObj)
        {
            if (tr.gameObject.activeSelf)
            {
                gameObjects.Add(tr.gameObject);
                countObj++;
            }
        }
    }

    public void RemoveObject(GameObject obj)
    {
        gameObjects.Remove(obj);
        if (canCheck)
        {
            if (gameObjects.Count <= countObj / 3)
            {
                GameManager.Instance.CheckLevelUp();
                canCheck = false;
            }
        }
    }
}
