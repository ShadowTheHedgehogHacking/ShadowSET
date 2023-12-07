using System.ComponentModel;

namespace ShadowSET
{
    public class Object14B5_GravityChangeZone : SetObjectShadow
    {
        // Also used for 14B4, GravityChangeSwitch
        [MiscSetting, Description("Sets the base gravity. By default the world is NegY")]
        public EGravityDirection GravityDirection { get; set; }
    }
}
