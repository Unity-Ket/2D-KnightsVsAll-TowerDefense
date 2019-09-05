using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] Defender defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquaredClicked());
        //Debug.Log("Mouse was Clicked: ");
    }

    public void SelectedDefender(Defender defenderToselect)
    {
        defender = defenderToselect;
        Debug.Log("Character Selected: " + defenderToselect.name);
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
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
        //Debug.Log("worldPos Position: " +roundedPos);
    }

}//DefenderSpawner
