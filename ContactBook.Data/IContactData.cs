﻿using ContactBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Data
{
    public interface IContactData
    {
        IEnumerable<Contact> GetAll();
    }

}