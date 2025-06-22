public class InscriptionConfig
{
    public string 铭文ID { get; set; }
    public string 铭文名称 { get; set; }
    public string 铭文等级 { get; set; }
    internal void LevelUP()
    {
        int MaxLevel = int.Parse(铭文等级);
        MaxLevel++;
        铭文等级 = MaxLevel.ToString();
        铭文等级 = (MaxLevel + 1).ToString();
    }
}
