using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class AWDungeonManager : MonoBehaviour
{
    public List<GameObject> FirstLevel = new List<GameObject>();
    public List<GameObject> SecondLevel = new List<GameObject>();
    public List<GameObject> ThirdLevel = new List<GameObject>();

    public int List1Count;
    public int List2Count;
    public int List3Count;

    public void GenerateDungeon()
    {
        List1Count = Random.Range(0, FirstLevel.Count);

        FirstLevel[List1Count].SetActive(true);


        List2Count = Random.Range(0, SecondLevel.Count);
        SecondLevel[List2Count].SetActive(true);

        List3Count = Random.Range(0, ThirdLevel.Count);
        ThirdLevel[List3Count].SetActive(true);
    }

    public void ExitDungeon()
    {
        FirstLevel[List1Count].SetActive(false);
        SecondLevel[List2Count].SetActive(false);
        ThirdLevel[List3Count].SetActive(false);
    }
}
