using UnityEngine;

public class ArmCollide : MonoBehaviour
{
    public bool touchWall;
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        
        touchWall = true;
    }
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        touchWall = false;
    }
}
