namespace GildedRose.Inventory
{
    public class NormalItem : GildedItem
    {
        public NormalItem(Item item, bool isConjured) : base(item, isConjured) { }
        protected override int CalculateQualityModifier(int sellIn) => sellIn > 0 ? -1 : -2;
    }
}
