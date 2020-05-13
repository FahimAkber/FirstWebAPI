namespace InfoAPI.Models
{
    public class InformationDataBaseSetting : IInformationDataBaseSetting
    {
        public string CollectionName{get; set;}
        public string ConnectionPort{get; set;}
        public string DataBaseName{get; set;}
    }
}