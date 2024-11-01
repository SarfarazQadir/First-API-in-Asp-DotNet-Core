using System.ComponentModel.DataAnnotations;

namespace First_API.Model
{
    public class Employee
    {

        [Key]
    public int E_Id { get; set; }
    public string E_Name { get; set; }
    public string E_Age { get; set; }
    public string E_City { get; set; }
    }
}
