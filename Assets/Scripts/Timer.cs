using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    public GameObject GO;
    private float Cooldown = 15;
    private float NewCooldown = 15;
    private int tiempo = 15;
    private TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
        texto = GO.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //texto.text = "Siguiente Horda " + Cooldown.ToString;
        texto.text = "Siguiente Horda " + tiempo;
        Cooldown-=  Time.deltaTime;
        tiempo = Mathf.RoundToInt(Cooldown);
        if (Cooldown <= 0) {
            NewCooldown -= 5;
            Cooldown = Mathf.Clamp (NewCooldown,10,100);
        }
    }
}
