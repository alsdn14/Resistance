using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestGage2 : MonoBehaviour
{

    public Image CursorGage4Image;

    private Cardboard MagnetButton;

    public Vector3 ScreenCenter;

    private float GageTimer;


    // Use this for initialization
    void Start()
    {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2,
                                   Camera.main.pixelHeight / 2);
        MagnetButton = GetComponent<Cardboard>();


    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);

        RaycastHit hit;

        CursorGage4Image.fillAmount = GageTimer;

        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.collider.CompareTag("BOX4"))
            {

                GageTimer += 1.0f / 5.0f * Time.deltaTime;
                if (GageTimer >= 1 )
                {
                    Application.LoadLevel(1);

                    GageTimer = 0;
                }
            }
        }

        else
            GageTimer = 0;
    }
}
