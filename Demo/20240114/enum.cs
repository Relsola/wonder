namespace Learn;

public enum SomeRootVegetable
{
  HorseRadish,
  Radish,
  Turnip
}

public enum Seasons
{
  None = 0,
  Summer = 1,
  Autumn = 2,
  Winter = 4,
  Spring = 8,
  All = Summer | Autumn | Winter | Spring
}
