namespace ShadowSET.ObjectClassesShadow {
    public class Object1130_FenceWall : SetObjectShadow {
        //Footing(model)
        public int Model {
            get => ReadInt(0);
            set => Write(0, value);
        }
    }
}
