using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
  public class Admin
    {
        private string AdminName;//账户
        private string AdminPwd;//密码
        private string Name;//姓名
        private string Sex;//性别
        private string Phone;//电话
        private string AdminRights;//权限

        public string AdminName1 { get => AdminName; set => AdminName = value; }
        public string AdminPwd1 { get => AdminPwd; set => AdminPwd = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Sex1 { get => Sex; set => Sex = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string AdminRights1 { get => AdminRights; set => AdminRights = value; }
    }
}
