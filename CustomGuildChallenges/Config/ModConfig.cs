﻿using System.Collections.Generic;

namespace CustomGuildChallenges
{
    // Global mod config
    public class ModConfig
    {
        public bool CustomChallengesEnabled { get; set; }
        public List<ChallengeInfo> Challenges { get; set; }

        public ModConfig()
        {
            Challenges = new List<ChallengeInfo>();
        }
    }
}
