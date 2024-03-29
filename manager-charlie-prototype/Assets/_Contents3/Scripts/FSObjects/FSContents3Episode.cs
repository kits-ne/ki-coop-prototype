﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Contents.QnA;
using CustomDebug;

namespace Contents3
{
    public class FSContents3Episode : QnAFiniteState
    {

        public override QnAContentsBase.State StateID
        {
            get
            {
                return QnAContentsBase.State.Episode;
            }
        }


        public override void Enter()
        {
            Entity.View.ShowEpisode();
        }

    }
}