using UnityEngine;
using DG.Tweening;

public class CameraVertical : MonoBehaviour
{
    public int FloorMaxAmount = 10;
    public float FloorHeight = 2.8f;
    private int _currentFloor = 1;
    private float _newY;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && _currentFloor < FloorMaxAmount)
        {
            _newY += FloorHeight;
            _currentFloor++;
            transform.DOMoveY(_newY, 1).SetEase(Ease.InOutSine);
        }

        if (Input.GetKeyDown(KeyCode.S) && _currentFloor > 1)
        {
            _newY -= FloorHeight;
            _currentFloor -= 1;
            transform.DOMoveY(_newY, 1).SetEase(Ease.InOutSine);
        }

    }
}
