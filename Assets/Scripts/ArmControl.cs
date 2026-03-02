using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class ArmControl : MonoBehaviour
{
    public GameObject hand;
    


    private StarterAssetsInputs _input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        hand.transform.position += (new Vector3(_input.moveArm.x, _input.moveArm.y, 0)) * Time.deltaTime;    
       
    }
    private void LateUpdate()
    {
       
    }
    public void OnLGrab(InputValue value)
    {
        
    }
   


}
