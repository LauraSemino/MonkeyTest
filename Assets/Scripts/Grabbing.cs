using StarterAssets;
using UnityEngine;
using UnityEngine.Windows;

public class Grabbing : MonoBehaviour
{
    private StarterAssetsInputs _input;
    public Collider LGrab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.lgrab == true)
        {
           // if (LGrab.
            //do thing
        }
        else
        {
            _input.lgrab = false;
        }
    }
   // private void OnTriggerStay(Collider obj)
  //  {
        //check mass
        

  //  }
}
