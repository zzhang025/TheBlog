﻿using System;
using System.ComponentModel;

namespace TheBlog.Models.Enum
{
	public enum ModerationType
	{
		[Description("Political Propaganda")]
		Political,
        [Description("Offensive Language")]
        Language,
        [Description("Drug References")]
        Drugs,
        [Description("Threatening Speech")]
        Threatening,
        [Description("Sexual Content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming
	}
}

