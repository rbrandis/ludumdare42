using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{

    /*Floors contain flats.
If a floor has at least one constructed flat, there is a cost.
There can be 4 flats in a floor.
You can look at floors.
When looking at a floor, there is a edit button. When you press it, you can choose a flat area and if it is empty, you can construct a flat in there. There are different types of flats with different costs.(see: Flats)
You can only go up a floor if the floor below is already filled with flats.
If there is already a flat, you can destroy it for a cost.*/

    public List<Flat> Flats = new List<Flat>();

    public FlatSpace[] Flatspaces; 
    
    public GameManager Manager;

    public GameObject FlatPrefab; 
    
    void Start()
    {
        foreach (FlatSpace space in Flatspaces)
        {
            space.OnFlatClicked += OnFlatSpaceClicked;
        }
    }

    private void OnFlatSpaceClicked(FlatSpace obj)
    {
        if (obj.Occupant == null) // if this is true FlatSpace is empty
        {
            // TODO: fill the space

            var flatObject = Instantiate(FlatPrefab);
            flatObject.transform.position = obj.transform.position;
            flatObject.transform.rotation = obj.transform.rotation;
            obj.Occupant = flatObject.GetComponent<Flat>();
        }
    }

    public void BuildFlat()
         {
             
             
         }



    // TODO
//    void OnMouseDown()
//    {
//        Build_UI.SetActive(true);
//    }
}
