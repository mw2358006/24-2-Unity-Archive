using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        Paladin knight = new Paladin("Sir Arthur");
        knight.PrintStatsInfo();
    }
}
