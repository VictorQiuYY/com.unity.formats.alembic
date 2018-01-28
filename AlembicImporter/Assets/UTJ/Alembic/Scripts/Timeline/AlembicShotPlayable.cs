﻿#if UNITY_2017_1_OR_NEWER

using UnityEngine.Playables;

namespace UTJ.Alembic
{
    public class AlembicShotPlayable : PlayableBehaviour
    {
        public AlembicStreamPlayer streamPlayer { get; set; }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            base.ProcessFrame(playable, info, playerData);

            if (streamPlayer == null)
                return;

            var duration = streamPlayer.m_streamDescriptor.duration;
            var time = (float)playable.GetTime();
            streamPlayer.m_currentTime = time == duration ? duration : time % duration;
        }
    }
}

#endif
