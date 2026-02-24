using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coliciones : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OncollisionsEnter");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionsStay");
    }
}