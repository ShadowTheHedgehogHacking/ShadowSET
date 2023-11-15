public abstract class SetObject
	{
		public float PosX;
		public float PosY;
		public float PosZ;
		public float RotX;
		public float RotY;
		public float RotZ;
		public byte List;
		public byte Type;
		public byte Link;
		public byte Rend;
		public byte[] UnkBytes;

		public byte[] MiscSettings;
		private ObjectEntry _objectEntry;
		public string GetName => _objectEntry.GetName();
		protected int ModelMiscSetting => _objectEntry.ModelMiscSetting;
		protected string[][] ModelNames => _objectEntry.ModelNames;
		public bool HasMiscSettings;

		public override string ToString()
		{
			return _objectEntry.GetName() + (Link == 0 ? "" : $" ({Link})");
		}

		public virtual void SetObjectEntry(ObjectEntry objectEntry)
		{
			this._objectEntry = objectEntry;
			this.HasMiscSettings = objectEntry.HasMiscSettings;
		}
	}

public class ObjectEntry
{
	public byte List;
	public byte Type;
	public string Name;
	public string DebugName;
	public int ModelMiscSetting;
	public string[][] ModelNames;
	public bool HasMiscSettings;
	public int MiscSettingCount;

	public override string ToString()
	{
		if (!string.IsNullOrWhiteSpace(Name))
			return string.Format("{0, 2:X2} {1, 2:X2} {2}", List, Type, Name);
		else if (!string.IsNullOrWhiteSpace(DebugName))
			return string.Format("{0, 2:X2} {1, 2:X2} {2}", List, Type, DebugName);
		else
			return string.Format("{0, 2:X2} {1, 2:X2} {2}", List, Type, "Unknown / Unused");
	}

	public string GetName()
	{
		if (Name != "")
			return Name;
		if (DebugName != "")
			return DebugName;
		return "Unknown/Unused";
	}
}
