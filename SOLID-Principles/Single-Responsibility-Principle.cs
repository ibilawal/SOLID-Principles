using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles
{

    interface IUser
    {
        bool Login(string _userName, string _password);
        bool Register(string _userName, string _password);
    }
    interface ILogger
    {
        void Log(string message);
    }
    interface IEmail
    {
        void SendEmail(string message);
    }
    internal class Single_Responsibility_Principle
    {
    }
}
