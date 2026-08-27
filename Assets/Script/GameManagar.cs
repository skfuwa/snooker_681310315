using UnityEngine;

public class GameManagar : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }
    public static GameManagar instance;

    public void Awake()
    {
      instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
