using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : Move
{
    private FabricaMove _fabrica;
    public ColectionMove MoveCollections;
    
   
    public Moving()
    {
      
        _move = new NoMove();
    }

    private void Start()
    {
        _fabrica = new FabricaMove(MoveCollections, this);
        setMove(_fabrica.CreateMove());
    }
    private void FixedUpdate()
    {

        transform.Translate(PerformMove());
    }

}

