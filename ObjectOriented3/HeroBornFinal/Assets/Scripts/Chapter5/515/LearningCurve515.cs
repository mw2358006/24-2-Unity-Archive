using UnityEngine;

public class LearningCurve515 : MonoBehaviour
{
    public Transform camTransform;
    public Transform lightTransform;
    public GameObject DirectionalLight;

    // Start is called before the first frame update
    void Start()
    {
        // DirectionalLight = GameObject.Find("Directional Light");
        // lightTransform = this.GetComponent<Transform>();
        lightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }
}
