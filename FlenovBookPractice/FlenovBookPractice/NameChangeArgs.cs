using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class NameChangeArgs : EventArgs
    {
        public enum NameChangingKind { FirstName, SecondName, LastName }

        public NameChangeArgs(string name, NameChangingKind nameKind)
        {
            NewName = name;
            NameKind = nameKind;
            Canceled = false;
        }

        public NameChangeArgs(string name, NameChangingKind nameKind, bool canceled)
        {
            NewName = name;
            NameKind = nameKind;
            Canceled = canceled;
        }

        public string NewName { get; set; }
        public bool Canceled { get; set; }

        public NameChangingKind NameKind { get; set; }
    }
}
