using UnityEngine;

public class F2FCarPassangerCarMovment : MonoBehaviour
{






    

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);


    }
}
