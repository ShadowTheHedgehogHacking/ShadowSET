using ShadowSET;

namespace ShadowSETTest
{
    public class SETOperations
    {
        private const string parentDirectory = "Assets\\";

        [Fact]
        public void ReadSET()
        {
            var shadow_0100_cmn = parentDirectory + Assets.Assets.shadow_stg0100_cmn;
            LayoutEditorSystem.SetupLayoutEditorSystem();
            var layout = LayoutEditorFunctions.GetShadowLayout(shadow_0100_cmn, out var result);
            Assert.Equal(504, layout.Count());
        }

        [Fact]
        public void ModifyAndWriteSETBox()
        {
            var shadow_0100_cmn = parentDirectory + Assets.Assets.shadow_stg0100_cmn;
            //var layout = new LayoutEditorSystem(shadow_0100_cmn);
            //LayoutEditorSystem.SetupLayoutEditorSystem();
            //var entries = layout.GetAllCurrentObjectEntries();

            LayoutEditorSystem.SetupLayoutEditorSystem();
            var layout = LayoutEditorFunctions.GetShadowLayout(shadow_0100_cmn, out var result);
            Assert.Equal(504, layout.Count());

            // Use LINQ to find indices of elements of type WoodBox
            List<(Object0009_WoodBox item, int index)> woodBoxItems = layout
                .Select((item, index) => new { Item = item, Index = index })
                .Where(pair => pair.Item is Object0009_WoodBox)
                .Select(pair => (Item: (Object0009_WoodBox)pair.Item, Index: pair.Index))
                .ToList();

            foreach (var woodbox in woodBoxItems)
            {
                woodbox.item.BoxItem = EBoxItem.Weapon;
                woodbox.item.ModifierWeapon = EWeapon.LaserRifle;
                layout[woodbox.index] = woodbox.item;
            }

            var test = "";
            //var originalLayout = Layout.GetShadowLayout(shadow_0100_cmn);
            //Assert.NotEqual(originalLayout, layout);

            /*            var woodboxes = layout.FindAll(item => item is Object0009_WoodBox).ConvertAll(item => (Object0009_WoodBox)item);;
                        foreach (var woodbox in woodboxes)
                        {
                            woodbox.ItemType = BoxItem.Weapon;
                            woodbox.ModifierWeapon = Weapon.LaserRifle;
                        }*/


        }
    }
}