﻿using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class PreviousSegmentFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Previous Segment"; }
        }

        public string Description
        {
            get { return "Displays how much time was saved or lost on the previous segment in relation to a comparison."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Information; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new PreviousSegment(state);
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string XMLURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/Components/update.LiveSplit.PreviousSegment.xml"; }
#else
            get { return "http://livesplit.org/update/Components/update.LiveSplit.PreviousSegment.xml"; }
#endif
        }

        public string UpdateURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/"; }
#else
            get { return "http://livesplit.org/update/"; }
#endif
        }

        public Version Version
        {
            get { return Version.Parse("1.6"); }
        }
    }
}
