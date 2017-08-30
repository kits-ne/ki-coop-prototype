﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Contents.QnA;

public class FSContents3ShowReward : QnAFiniteState
{

    public override QnAContentsBase.State StateID
    {
        get
        {
            return QnAContentsBase.State.Reward;
        }
    }

    public override void Initialize()
    {

    }
    public override void Enter()
    {
        Entity.View.ShowReward();
    }
    public override void Exit()
    {

    }
    public override void Excute()
    {

    }
}
