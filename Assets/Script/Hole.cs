using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       Ball b = other.GetComponent<Ball>();

        if(b != null)
        { 
            GameManagar.instance.PlayerScore += b.Point;  
            Destroy(b.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
