using System.ComponentModel;

namespace ShadowSET
{
    public class Object0061_DarkSpinEntrance : SetObjectShadow
    {
        [MiscSetting, Description("Only valid where a darkspin spline exists")]
        public float Radius { get; set; }
    }
}
