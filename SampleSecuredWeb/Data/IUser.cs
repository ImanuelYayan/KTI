using System;
using SampleSecuredWeb.Models;

namespace SampleSecuredWeb.Data;

public interface IUser
{
    User Registration(User user);
    User Login(User user);

}
