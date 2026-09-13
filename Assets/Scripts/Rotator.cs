using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(45 * Time.deltaTime, 0, 0);
    }
}