using System;

namespace bookeeping.ViewModels
{
    public class SignInViewModel
    {
        public string Name{ get; set; }
        public string Password{ get; set; }
        public bool RememberMe{ get; set; }
    }
}