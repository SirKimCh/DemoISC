using DemoISC.Models;

namespace DemoISC.Interface
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student?> GetStudentByIdAsync(int id);
        Task<Student> CreateStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);
        Task<bool> DeleteStudentAsync(int id); 
    }
}
