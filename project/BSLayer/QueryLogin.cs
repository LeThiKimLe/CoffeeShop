using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BSLayer
{
    class QueryLogin
    {
        public Person Login(string enteredUsername, string enteredPassword)
        {
            // Tạo DataContext
            DataClasses1DataContext db = new DataClasses1DataContext();
            // Truy vấn dữ liệu sử dụng LINQ
            var user = (from u in db.Users where u.contact == enteredUsername && u.password == enteredPassword select u).FirstOrDefault(); 
            // Xác thực người dùng
            if (user != null) 
            {
                if (user.Role.id == 1)
                    return new Manager(user.name, user.contact, user.id);
                else if (user.Role.id == 2)
                    return new Barista(user.name, user.contact, user.id);
                else return new Customer(user.name, user.contact, user.id);
            } else {
                return null; 
            } 
        }
        }
}
