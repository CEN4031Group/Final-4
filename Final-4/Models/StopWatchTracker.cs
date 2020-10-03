﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_4.Models
{
    public class StopWatchTracker
    {
        public StopWatchTracker(DateTime _elapsedTime)
        {
            ElapsedTime = _elapsedTime.ToString("dd/MM/yyyy hh:mm:ss.fff");
            TimeCreated = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
        }

        public StopWatchTracker()
        {
            ElapsedTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            TimeCreated = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; private set; }
        public string ElapsedTime { get; private set; }

        public string TimeCreated
        {
            get; private set;
        }
    }
}
