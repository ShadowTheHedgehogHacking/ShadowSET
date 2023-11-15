using System.ComponentModel;

namespace ShadowSET.ObjectClassesShadow {
    public class Object005A_Pole : SetObjectShadow {
        //CatchStick

        [Description("Extends equally up/down from object location")]
        public float Length {
            get => ReadFloat(0);
            set => Write(0, value);
        }
    }
}
