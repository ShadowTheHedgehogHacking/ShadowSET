using System.ComponentModel;

namespace ShadowSET.ObjectClassesShadow {
    public class Object1903_BlackDoomHologram : SetObjectShadow {
        //BDHologram

        [Description("Distance (straight line) from player to object\nWhen met, the hologram disappears.")]
        public float DetectDistance {
            get => ReadFloat(0);
            set => Write(0, value);
        }

        public int VoiceID {
            get => ReadInt(4);
            set => Write(4, value);
        }
    }
}
