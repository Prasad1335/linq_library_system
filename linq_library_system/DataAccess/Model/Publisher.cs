using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace linq_library_system.DataAccess.Model;
[Table("Publisher")]
public class Publisher
{
    [Key]

    [Column("Publisher_Id")]
    public int PublisherId { get; set; }

    [Column("Publisher_Name",TypeName ="varchar(100)")]
    public string PublisherName { get; set; }   

}
