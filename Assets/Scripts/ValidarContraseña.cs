using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseniaCorrecta;
    public Text ingresoUsuario;
    string contraseniaUsuario;
    public GameObject CartelMsj;
    public Text textoMsj;
    // Start is called before the first frame update
    void Start()
    {
        CartelMsj.SetActive(false);
        contraseniaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContraseña()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            Debug.Log("Bienvenido");
            CartelMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
        }
        else
        {
            CartelMsj.SetActive(true);
            Debug.Log("Contraseña Incorrecta");
            textoMsj.text = "Contraseña Incorrecta";
        }
    }
}
