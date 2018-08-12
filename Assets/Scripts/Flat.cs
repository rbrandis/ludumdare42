using System;
using UnityEngine;

public class Flat : MonoBehaviour
{
    /*

There are different types of flats.
Different flats have different:

    construction cost
    running cost
    rent

*/

    public int ConstructionCost;
    public int RunningCost;
    public int Rent;
    
    public event Action<Flat> OnFlatClicked;
    
    void Start()
    {
    }

    void Update()
    {
    }

    private void OnMouseUp()
    {
        if (OnFlatClicked != null) OnFlatClicked(this);
    }
}
