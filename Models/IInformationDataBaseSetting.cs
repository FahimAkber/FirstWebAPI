namespace InfoAPI.Models
{
    public interface IInformationDataBaseSetting
    {
         string CollectionName{get; set;}
         string ConnectionPort{get; set;}
         string DataBaseName{get; set;}
    }
}