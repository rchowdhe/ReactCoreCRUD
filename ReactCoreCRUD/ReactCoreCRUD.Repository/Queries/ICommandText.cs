using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreCRUD.Repository.Queries
{
    public interface ICommandText
    {
        string GetAllUsers { get; }
        string GetUserById { get; }
        string InsertUser { get; }
        string UpdateUser { get; }
        string DeleteUser { get; }
        string GetUserById_SP { get; }
    }
}
