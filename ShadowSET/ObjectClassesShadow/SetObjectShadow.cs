using System;

public abstract class SetObjectShadow : SetObject
	{
		public SetObjectShadow()
		{
			UnkBytes = new byte[8];
			MiscSettings = new byte[0];
		}
		
		public string DefaultMiscSettingCount { get; private set; }

		public override void SetObjectEntry(ObjectEntry objectEntry)
		{
			base.SetObjectEntry(objectEntry);

			if (objectEntry.MiscSettingCount == -1)
				DefaultMiscSettingCount = "Unknown";
			else
				DefaultMiscSettingCount = (objectEntry.MiscSettingCount / 4).ToString();
		}

		public int ReadInt(int j) => BitConverter.ToInt32(MiscSettings, j);

		public float ReadFloat(int j) => BitConverter.ToSingle(MiscSettings, j);

		public void Write(int j, int value)
		{
			for (int i = 0; i < 4; i++)
				MiscSettings[j + i] = BitConverter.GetBytes(value)[i];
		}

		public void Write(int j, float value)
		{
			for (int i = 0; i < 4; i++)
				MiscSettings[j + i] = BitConverter.GetBytes(value)[i];
		}

/*    public virtual void WriteMiscSettings(BinaryWriter writer)
    {
        foreach (var (property, attribute) in MiscProperties)
        {
            var underlyingType = MiscSettingAttribute.GetUnderlyingType(property.PropertyType, attribute.UnderlyingType);

            switch (underlyingType)
            {
                case MiscSettingUnderlyingType.Int:
                    while (writer.BaseStream.Position % 4 != 0)
                        writer.BaseStream.Position++;
                    writer.Write(Convert.ToInt32(property.GetValue(this)));
                    break;
                case MiscSettingUnderlyingType.Float:
                    while (writer.BaseStream.Position % 4 != 0)
                        writer.BaseStream.Position++;
                    writer.Write(Convert.ToSingle(property.GetValue(this)));
                    break;
                case MiscSettingUnderlyingType.Short:
                    while (writer.BaseStream.Position % 2 != 0)
                        writer.BaseStream.Position++;
                    writer.Write(Convert.ToInt16(property.GetValue(this)));
                    break;
                case MiscSettingUnderlyingType.Byte:
                    writer.Write(Convert.ToByte(property.GetValue(this)));
                    break;
            }

            writer.BaseStream.Position += attribute.PadAfter;
        }
    }*/
}
