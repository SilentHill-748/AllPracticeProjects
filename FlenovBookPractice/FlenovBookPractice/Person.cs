using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void NameChanged(object sender, NameChangeArgs e);

    public class Person
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                var nameArgs = new NameChangeArgs(value, 
                    NameChangeArgs.NameChangingKind.FirstName);
                FirstNameChange?.Invoke(this, nameArgs);

                if (nameArgs.Canceled) return;
                _firstName = value;
            }
        }

        private string _secondName;
        public string SecondName
        {
            get => _secondName;
            set
            {
                SecondNameChange?.Invoke(this, new NameChangeArgs(
                    value, NameChangeArgs.NameChangingKind.SecondName));
                _secondName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                LastNameChange?.Invoke(this, new NameChangeArgs(
                    value, NameChangeArgs.NameChangingKind.LastName));
                _lastName = value;
            }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 & value > 100)
                    throw new Exception("Пошел нахуй.");
                AgeChange.Invoke(this, new EventArgs());
                _age = value;
            }
        }

        public event EventHandler AgeChange;
        public event NameChanged FirstNameChange;
        public event NameChanged SecondNameChange;
        public event NameChanged LastNameChange;
    }
}