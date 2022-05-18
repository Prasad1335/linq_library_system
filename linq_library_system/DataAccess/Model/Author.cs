using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace linq_library_system.DataAccess.Model;
[Table("Author_table")]
public class Author
{
    [Key]
    [Column("Author_Id")]
    public int AuthorId { get; set; }

    [Column("Author_Name",TypeName ="varchar(100)")]
    public string AuthorName { get; set; }
}
