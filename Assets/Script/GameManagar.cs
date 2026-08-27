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

    [SerializeField]
    private GameObject[] ballPositions;
    [SerializeField]
    private GameObject ballPrefabs;
    public static GameManagar instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        SetBall(BallColor.Red, 1);
        SetBall(BallColor.Yellow, 2);
        SetBall(BallColor.Green, 3);
        SetBall(BallColor.Brown, 4);
        SetBall(BallColor.Blue, 5);
        SetBall(BallColor.Pink, 6);
        SetBall(BallColor.Black, 7);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SetBall(BallColor color,int i)
    {
        GameObject obj = Instantiate(ballPrefabs,
                                     ballPositions[i].transform.position,
                                     Quaternion.identity);

        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(color);

    }
}
