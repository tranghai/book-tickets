using System;
using System.Collections.Generic;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.ViewModels
{
    public class SettingViewModel : ViewModelBase
    {
        public List<Setting> ListAccountSetting { get; set; }
        public List<Setting> ListSupportSetting { get; set; }
        public SettingViewModel()
        {
            Title = "Setting";
            Icon = "setting_6mdpi.png";

            ListAccountSetting = GetAccountSetting();
            ListSupportSetting = GetSupportSetting();
        }

        public List<Setting> GetAccountSetting()
        {
            return new List<Setting>()
            {
                new Setting(() =>{ }){ Id = 1, Name = "Change Password"},
                new Setting(() =>{ }){ Id = 2, Name = "Change Mobile Number"},
                new Setting(() =>{ }){ Id = 3, Name = "Two-Step Verification"},
                new Setting(() =>{ }){ Id = 4, Name = "Change Email"},
            };
        }

        public List<Setting> GetSupportSetting()
        {
            return new List<Setting>()
            {
                new Setting(() =>{ }){ Id = 1, Name = "Careers"},
                new Setting(() =>{ }){ Id = 2, Name = "Help and Support"},
                new Setting(() =>{ }){ Id = 3, Name = "About Us"},
                new Setting(() =>{ }){ Id = 4, Name = "Contact Us"},
                new Setting(() =>{ }){ Id = 4, Name = "Privacy Policy"},
                new Setting(() =>{ }){ Id = 4, Name = "Terms of Use"},
                new Setting(() =>{ }){ Id = 4, Name = "Disclaimer"},
                new Setting(() =>{ }){ Id = 4, Name = "Logout"},
            };
        }
    }

    public class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DelegateCommand Command { get; set; }

        public Setting(Action action)
        {
            Command = new DelegateCommand(action);
        }
    }
}
