using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        Character villain = hero;
        villain.name = "Sir. Krane the Brave";
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();
    }
}
