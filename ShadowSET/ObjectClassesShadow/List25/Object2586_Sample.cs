namespace ShadowSET.ObjectClassesShadow {
    public class Object2586_Sample : SetObjectShadow {

        public int Uint32 {
            get => ReadInt(0);
            set => Write(0, value);
        }

        public int Sint32 {
            get => ReadInt(4);
            set => Write(4, value);
        }
    }
}

