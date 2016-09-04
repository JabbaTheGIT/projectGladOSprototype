//William Gwilt n9425438
//NSC Industries prject GladOS

using Android;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.OS;

namespace GladOS.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string update = "";

        public string Update
        {
            get { return update; }

            set
            {
                update = value;
                RaisePropertyChanged(() => Update);
            }
        }

        public ICommand HomePressed { get; private set; }
        public ICommand SchedulePressed { get; private set; }
        public ICommand SearchPressed { get; private set; }
        public ICommand ProfilePressed { get; private set; }
        public ICommand InAMeetingPressed { get; private set; }
        public ICommand OfficeHoursPressed { get; private set; }
        public ICommand BusyPressed { get; private set; }
        public ICommand FreeTimePressed { get; private set; }
        public ICommand Calendar { get; private set; }
        public FirstViewModel()
        {
            HomePressed = new MvxCommand(() =>
            {
                Update = "Home Pressed";
            });

            SchedulePressed = new MvxCommand(() =>
            {
                Update = "Scedule Pressed";
            });

            SearchPressed = new MvxCommand(() =>
            {
                Update = "Search Pressed";
            });

            ProfilePressed = new MvxCommand(() =>
            {
                Update = "Profile Pressed";
            });

            InAMeetingPressed = new MvxCommand(() =>
            {
                Update = "Indicate you are in a meeting";
            });

            OfficeHoursPressed = new MvxCommand(() =>
            {
                Update = "Show your office hours";
            });

            BusyPressed = new MvxCommand(() =>
            {
                Update = "Busy / Private Time";
            });

            FreeTimePressed = new MvxCommand(() =>
            {
                Update = "Free for meetings or meetup time";
            });

            Calendar = new MvxCommand(() =>
            {
                Update = "Update Calendar and schedule";
            });
        }
    }
}
