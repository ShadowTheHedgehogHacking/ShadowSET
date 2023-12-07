using System.ComponentModel;

namespace ShadowSET
{
    public class Object1903_BlackDoomHologram : SetObjectShadow
    {
        //BDHologram

        [MiscSetting, Description("Distance (straight line) from player to object\nWhen met, the hologram disappears.")]
        public float DetectDistance { get; set; }
        [MiscSetting]
        public int VoiceID { get; set; }
    }
}
