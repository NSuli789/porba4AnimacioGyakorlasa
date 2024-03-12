using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarimozog : MonoBehaviour
{
    // csak induláskor valósul meg
    void Start()
    {
        
    }

    // újra és újra megtörténik
    void Update()
    {
        //mozgáshoz a definició

        // var: változó nincs mert nem tudom mi lesz a típusa
        // most az x_irany változó fel va töltve a vízszintes iránnyal jobbra és balra
        var x_irany = Input.GetAxisRaw("Horizontal");

        // jöhet a felfelé és lefelé irányuló mozgás
        var y_irany = Input.GetAxisRaw("Vertical"); //"" ebben vannak a gombok neve
        // egy feltétel kell miszerint ha az irányító gomb le van nyomva tehát nem egyenlõ 0-val
        if (x_irany != 0)
        {
            // azért vector2 mert 2 dimenziós játékról van szó
            // deltaTime egy alap idõ egység az updaten belül

            transform.Translate(new Vector2(Time.deltaTime * 10 * x_irany, 0));
        }

        if (y_irany != 0)
        {
            transform.Translate(new Vector2(0, Time.deltaTime * 10 * y_irany));
        }
    }
}
