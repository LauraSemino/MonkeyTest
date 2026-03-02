using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class ArmControl : MonoBehaviour
{
    public GameObject hand;
    public CharacterController controller;
    public float PullTimeout = 0.4f;

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
        if (PullTimeout > 0f && _input.lgrab == true)
        {
            controller.Move((hand.transform.position - transform.position) * Time.deltaTime * 5);
            PullTimeout -= Time.deltaTime;
        }

        if (PullTimeout <= 0)
        {
            _input.lgrab = false;
            PullTimeout = 0.4f;
        }

    }
    private void LateUpdate()
    {
       
    }
  
   


}
