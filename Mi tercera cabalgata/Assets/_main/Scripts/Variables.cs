using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class Variables : MonoBehaviour
{
    //Declarar variables

    public string myName = "Nicol";
    public int edad = 18;
    public bool isBool;

    [SerializeField] private TMP_InputField _inputfield;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _boxCollider;

   

    // Start is called before the first frame update 
    void Start()
    {
        _cubo.material.color = Color.blue;
        _boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        myName = _inputfield.text; 
        _saludo.text = "Saludo " + myName;
    }
}
