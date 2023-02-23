

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using danj_backend.Data;

namespace danj_backend.Model{
    public class Users : IEntity {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string firstname {get;set;}
        public string middlename {get;set;}
        public string lastname {get;set;}
        [Required]
        public string email {get;set;}
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
    }
}