﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class ErrorReport : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime Deadline { get; set; }




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
