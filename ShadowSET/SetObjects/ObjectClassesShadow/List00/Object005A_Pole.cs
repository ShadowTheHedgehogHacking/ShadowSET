﻿using System.ComponentModel;

namespace ShadowSET
{
    public class Object005A_Pole : SetObjectShadow
    {
        //CatchStick

        [MiscSetting, Description("Extends equally up/down from object location")]
        public float Length { get; set; }
    }
}
