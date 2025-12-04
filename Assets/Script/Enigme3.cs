using UnityEngine;

public class Enigme3 : MonoBehaviour
{
    public GameObject Corde1;
    public GameObject Corde2;
    public GameObject Corde3;
    public GameObject Corde4;

    public GameObject Offset1;
    public GameObject Offset2;

    public Vector3 bHeight;
    public float baseHeight;

    public Transform Sarcophage;
    public float ratio = 1f;

    public float deltaC1;
    public float deltaC2;
    public float deltaC3;
    public float deltaC4;

    public Vector3 PLACEHOLDERAXIS;
    public Animator reset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bHeight = Corde1.transform.position;
        baseHeight = bHeight.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaC1 = Corde1.transform.position.y - baseHeight;
        deltaC2 = Corde2.transform.position.y - baseHeight;
        deltaC3 = Corde3.transform.position.y - baseHeight;
        deltaC4 = Corde4.transform.position.y - baseHeight;

        if (deltaC1 != 0)
        {
            reset.SetBool("isOn", false);
            float rotation = deltaC1 * ratio;
            Sarcophage.Rotate(Offset1.transform.forward, rotation);
        }

        if (deltaC2 != 0) 
        {
            reset.SetBool("isOn", false);
            float rotation = deltaC2 * ratio;
            Sarcophage.Rotate(Offset2.transform.forward, rotation);
        }
        if (deltaC3 != 0)
        {
            reset.SetBool("isOn", false);
            float rotation = deltaC3 * ratio;
            Sarcophage.Rotate(-Offset2.transform.forward, rotation);
        }

        if (deltaC4 != 0)
        {
            reset.SetBool("isOn", false);
            float rotation = deltaC4 * ratio;
            Sarcophage.Rotate(-Offset1.transform.forward, -rotation);
        }

        else
        {
            reset.SetBool("isOn", true);
        }
    }
}
