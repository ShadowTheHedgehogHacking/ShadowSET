using ShadowSET;
using ShadowSET.SETIDBIN;
using System.Collections.Generic;

namespace ShadowSETTest
{
    public class SETIDOperations
    {
        private const string parentDirectory = "Assets\\";

        [Fact]
        public void ReadShadowSETIDBIN()
        {
            var setidbin = parentDirectory + Assets.Assets.shadow_setidbin;
            LayoutEditorSystem.SetupLayoutEditorSystem();
            var setidTable = SetIdTableFunctions.LoadTable(setidbin, true, LayoutEditorSystem.shadowObjectEntries);

            var gunsoldierList = 0x0;
            var gunsoldierType = 0x64;


            foreach (TableEntry entry in setidTable)
            {
                if (entry.objectEntry.List == gunsoldierList && entry.objectEntry.Type == gunsoldierType)
                {
                    foreach (StageEntry stage in LayoutEditorSystem.shadowStageEntries)
                    {
                        entry.values0 |= stage.flag0;
                        entry.values1 |= stage.flag1;
                        entry.values2 |= stage.flag2;
                    }
                }
            }

            SetIdTableFunctions.SaveTable("debugTable.bin", true, setidTable);
            // validated in HPP
        }
    }
}