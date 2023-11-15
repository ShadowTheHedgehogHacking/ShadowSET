using System.ComponentModel;
using static ShadowSET.Layout;

namespace ShadowSET
{
	public class LayoutEditorSystem
	{
		public LayoutEditorSystem(string currentlyOpenFileName)
		{
			CurrentlyOpenFileName = currentlyOpenFileName;
		}

		public string CurrentlyOpenFileName { get; }

		public static Dictionary<(byte, byte), ObjectEntry> shadowObjectEntries { get; private set; }
		public static ObjectEntry shadowObjectEntry(byte List, byte Type) => shadowObjectEntries[(List, Type)];
		
		public static void SetupLayoutEditorSystem(){
			var resourcePath = "Resources/ShadowObjectList.ini";
			shadowObjectEntries = ReadObjectListData(resourcePath);
		}

		private BindingList<SetObject> setObjects { get; set; } = new();

		public int GetSetObjectAmount()
		{
			return setObjects.Count;
		}

		public SetObject GetSetObjectAt(int index)
		{
			return setObjects[index];
		}

		public static IEnumerable<ObjectEntry> GetAllObjectEntries()
		{
			List<ObjectEntry> list = new List<ObjectEntry>();
			list.AddRange(shadowObjectEntries.Values);

			return list;
		}

		public static ObjectEntry[] GetActiveObjectEntries()
		{
			return shadowObjectEntries.Values.ToArray();
		}

		public (byte, byte)[] GetAllCurrentObjectEntries()
		{
			HashSet<(byte, byte)> objectEntries = new HashSet<(byte, byte)>();

			foreach (SetObject s in setObjects)
				if (!objectEntries.Contains((s.List, s.Type)))
					objectEntries.Add((s.List, s.Type));

			return objectEntries.ToArray();
		}
	}
}
