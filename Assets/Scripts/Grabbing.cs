using StarterAssets;
using UnityEngine;
using UnityEngine.Windows;

public class Grabbing : MonoBehaviour
{
    private StarterAssetsInputs _input;
    public GameObject camTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawLine(transform.position, camTransform.transform.forward * 5, Color.pink);

        if (_input.lgrab == true)
        {
            
            RaycastHit hit; 
            if(Physics.SphereCast(new Vector3(transform.position.x - 0.35f, transform.position.y , transform.position.z) ,0.25f, camTransform.transform.forward, out hit,3f))
            {
                Debug.Log(hit.rigidbody.gameObject.name);
            }
            _input.lgrab = false;
            // if (LGrab.
            //do thing
        }
        else
        {
            
        }
    }
   // private void OnTriggerStay(Collider obj)
  //  {
        //check mass
        

  //  }
}
