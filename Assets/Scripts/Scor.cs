using UnityEngine;
using UnityEngine.UI;

public class Scor : MonoBehaviour
{
    public static int scor;
    public Text scorText;
    void Start()
    {
        scor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scorText.text = scor.ToString();
    }
}
