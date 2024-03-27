using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class TestScript : MonoBehaviour
{
    public float AlienRoation;
    public Sprite sprite1;
    public Sprite sprite2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        
    }

    void Update()
    {
        Sprite sprite = GetComponent<Sprite>();
        AlienRoation =+ 0.5f;
        if (AlienRoation == 360) {
            AlienRoation = 0; 
            if (sprite = sprite1)
            {
                sprite = sprite2;
            }
        
        }
        transform.Rotate(new Vector3(Quaternion.identity.x, Quaternion.identity.y, AlienRoation));
      
        

    }
}
