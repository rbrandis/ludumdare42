using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /*Game has rounds called weeks.
        At the end of a week, costs are paid, rents are collected.
        The UI shows the current amount of money.
        It also shows this week's expected earning and expenses like (+5250/-3000)*/

    [Tooltip("Round Length in Seconds")] public float RoundLength;

    public Text FundsDisplay;
    public Text RentWeeklyDisplay;
    public Text RunningCostsWeeklyDisplay;

    public int Funds = 0;
    public int Rents = 10;
    public int RunningCosts = 100;

    public Floor[] Floors;

    void Start()
    {
        SetText();

        foreach (var floor in Floors)
        {
            floor.Manager = this;
        }
    }
    
    public void OnClickCompleteWeek()
    {
        Debug.Log("Round complete");

        Funds += (Rents - RunningCosts);
        SetText();

    }

    void SetText()
    {
        FundsDisplay.text = "Funds: " + Funds;
        RentWeeklyDisplay.text = "Weekly Income: " + Rents;
        RunningCostsWeeklyDisplay.text = "Weekly Running Costs: " + RunningCosts;
    }

    public void FlatClicked(Flat flat)
    {

    }
}