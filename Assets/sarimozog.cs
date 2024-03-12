using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarimozog : MonoBehaviour
{
    // csak indul�skor val�sul meg
    void Start()
    {
        
    }

    // �jra �s �jra megt�rt�nik
    void Update()
    {
        //mozg�shoz a definici�

        // var: v�ltoz� nincs mert nem tudom mi lesz a t�pusa
        // most az x_irany v�ltoz� fel va t�ltve a v�zszintes ir�nnyal jobbra �s balra
        var x_irany = Input.GetAxisRaw("Horizontal");

        // j�het a felfel� �s lefel� ir�nyul� mozg�s
        var y_irany = Input.GetAxisRaw("Vertical"); //"" ebben vannak a gombok neve
        // egy felt�tel kell miszerint ha az ir�ny�t� gomb le van nyomva teh�t nem egyenl� 0-val
        if (x_irany != 0)
        {
            // az�rt vector2 mert 2 dimenzi�s j�t�kr�l van sz�
            // deltaTime egy alap id� egys�g az updaten bel�l

            transform.Translate(new Vector2(Time.deltaTime * 10 * x_irany, 0));
        }

        if (y_irany != 0)
        {
            transform.Translate(new Vector2(0, Time.deltaTime * 10 * y_irany));
        }
    }
}
