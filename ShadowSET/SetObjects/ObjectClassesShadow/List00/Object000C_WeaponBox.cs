﻿namespace ShadowSET
{
    public class Object000C_WeaponBox : SetObjectShadow
    {
/*        public override void CreateTransformMatrix()
        {
            // function 800c9ed4 | RotationTemplateGen
            var shift = MathUtil.Pi / 180f;
            transformMatrix =
                Matrix.RotationZ(Rotation.Z * shift) *
                Matrix.RotationX(Rotation.X * shift) *
                Matrix.RotationY(Rotation.Y * shift) *
                Matrix.Translation(Position.X, Position.Y + 10f, Position.Z);
            CreateBoundingBox();
        }*/

        [MiscSetting]
        public EBoxType BoxType { get; set; }
        [MiscSetting]
        public EWeapon Weapon { get; set; }
    }
}
