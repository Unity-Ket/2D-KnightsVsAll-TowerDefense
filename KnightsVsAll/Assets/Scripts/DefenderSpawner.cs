using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquaredClicked());
        //Debug.Log("Mouse was Clicked: ");
    }

    private Vector2 GetSquaredClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //Debug.Log("Mouse Position: " + Input.mousePosition.x + " x / " + Input.mousePosition.y + " y");
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnaptoGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnaptoGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }


    private void SpawnDefender(Vector2 roundedPos)
    {
        GameObject newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as GameObject;
        Debug.Log("worldPos Position: " +roundedPos);
    }

}//DefenderSpawner
