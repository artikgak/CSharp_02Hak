using System;
using System.Threading.Tasks;
using System.Windows;
using KMACSharp02_03Hak.Exceptions;
using KMACSharp02_03Hak.Models;
using KMACSharp02_03Hak.Tools;
using KMACSharp02_03Hak.Tools.Managers;
using KMACSharp02_03Hak.Tools.MVVM;

namespace KMACSharp02_03Hak.ViewModels.DatePicker
{
    internal class DateViewModel : BaseViewModel
    {
        #region Fields

        private string _name;
        private string _surname;
        private string _email;
        private DateTime? _birthDate = DateTime.Today;
        private string _personInfo;

        #region Commands
        private RelayCommand<object> _proceedCommand;
        #endregion

        #endregion

        #region Properties

        public DateTime? BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                OnProperyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnProperyChanged();
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnProperyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnProperyChanged();
            }
        }

        public string PersonInfo
        {
            get
            {
                return _personInfo;

            }
            private set
            {
                _personInfo = value;
                OnProperyChanged();
            }
        }

        #region Commands

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand ?? (_proceedCommand = new RelayCommand<object>(
                           SelectDateImplementation, o=>CanExecuteCommand()));
            }
        }

        #endregion

        #endregion

        private bool CanExecuteCommand()
        {
            return !(string.IsNullOrWhiteSpace(_name) || string.IsNullOrWhiteSpace(_surname) ||
                     string.IsNullOrWhiteSpace(_email) || _birthDate==null);
        }

        private async void SelectDateImplementation(object o)
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
                {
                    try
                    {
                        Person person = new Person(Name, Surname, Email, (DateTime) BirthDate);
                        PersonInfo = $"Name: {person.Name}\nSurname: {person.Surname}\nEmail: {person.Email}\n" +
                                     $"BirthDate: {person.BirthDate.ToShortDateString()}\n" +
                                     $"IsBirthday: {person.IsBirthday}\nIsAdult: {person.IsAdult}\n" +
                                     $"ChineseSign: {person.ChineseSign}\nSunSign: {person.SunSign}";
                        if (person.IsBirthday)
                            MessageBox.Show("Happy Birthday! Have a nice day");
                    }
                    catch (InvalidNameException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    catch (InvalidSurnameException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    catch (InvalidEmailException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    catch (BirthDateInFutureException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    catch (BirthDateInLongPastException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            );
            LoaderManager.Instance.HideLoader();
        }
    }
}
