namespace InfoAPI.Models
{
    public class InfoDataBaseSetting : IInfoDataBaseSetting
    {
        public string CollectionName{get; set;}
        public string ConnectionPort{get; set;}
        public string DataBaseName{get; set;}
    }
}