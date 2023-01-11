using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;



public class playerAttributes
{

    private state playerState;

    public enum state { Normal, Paused, Inventory };
    public playerAttributes()
    {
        playerState = state.Normal;

    }
    
    public state GetPlayerState()
    {
        return playerState;
    }

    public void SetPlayerState(state newPlayerState)
    {
        playerState = newPlayerState;
    }
    


    


}
