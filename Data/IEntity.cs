namespace danj_backend.Data
{
    public interface IEntity {
        int Id { get; set; }
        string firstname {get;set;}
        string middlename { get; set; }
        string lastname {get;set;}
        string email {get;set;}
        string password {get;set;}
    }
}