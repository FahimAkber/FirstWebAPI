namespace InfoAPI.Models
{
    public interface IInfoDataBaseSetting
    {
         string CollectionName{get; set;}
         string ConnectionPort{get; set;}
         string DataBaseName{get; set;}
    }
}