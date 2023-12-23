using UnityEngine;

public class AlfaTop : MonoBehaviour
{

    public bool alfa = true;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            alfa = !alfa;
        }

        if (alfa == true) //While play mode
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f); ;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
        }
    }
}
