using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public int points = 0;
    public string uiText = "Points";

    public List<GameObject> spawners = new List<GameObject>();
    public List<GameObject> smallCircle = new List<GameObject>();
    public List<GameObject> colorChanger = new List<GameObject>();

    public void RemoveFromSpawners(GameObject spawnerToRemove)
    {
        spawners.Remove(spawnerToRemove);
    }

    private void LateUpdate()
    {
        uiText = "Points: " + points;

        pointsText.SetText(uiText);
    }

    public void AddPoints(int pointsValue)
    {
        points = points + pointsValue;
    }

}
