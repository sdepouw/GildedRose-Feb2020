namespace GildedRose.Inventory
{
    public class BackstagePassesItem : GildedItem
    {
        public BackstagePassesItem(Item item, bool isConjured) : base(item, isConjured) { }

        protected override int CalculateQualityModifier(int sellIn)
        { 
            int qualityModifier = 1;
            if (sellIn <= 10)
            {
                qualityModifier++;
            }
            if (sellIn <= 5)
            {
                qualityModifier++;
            }
            if (sellIn <= 0)
            {
                return -int.MaxValue;
            }
            return qualityModifier;
        }
    }
}
