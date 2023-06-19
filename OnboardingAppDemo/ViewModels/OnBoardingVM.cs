using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingAppDemo.Models;

namespace OnboardingAppDemo.ViewModels
{
    public class OnBoardingVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<OnboardingModel> OnboardingModels { get; set; } = new();

        public OnBoardingVM()
        {
            OnboardingModels.Add(new OnboardingModel("img1.jpg", "Introduction to Robotics", "This heading introduces the field of robotics, covering topics such as the history of robotics, basic components of a robot, and various applications of robotics in different industries."));
            OnboardingModels.Add(new OnboardingModel("img2.jpg", "Benefits of Regular Exercise", "In this section, we explore the benefits of regular exercise on physical and mental health. Topics covered include improved cardiovascular fitness, weight management, stress reduction, and enhanced mood."));
            OnboardingModels.Add(new OnboardingModel("img3.jpg", "Beginner's Guide to Cooking", "This guide is designed for beginners who want to learn cooking basics. It covers essential kitchen tools, cooking techniques, and simple recipes to get started on the culinary journey."));
            OnboardingModels.Add(new OnboardingModel("img4.jpg", "Exploring National Parks", "Discover the natural wonders of national parks in this section. From breathtaking landscapes to diverse wildlife, we delve into the unique features of popular national parks and offer travel tips for an unforgettable experience."));
        }

        private bool isLastStep;

        public bool IsLastStep
        {
            get { return isLastStep; }
            set
            {
                if (isLastStep != value)
                {
                    isLastStep = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLastStep)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsNotLastStep)));
                }

            }
        }

        //shorthand way of implementing a read-only property
        public bool IsNotLastStep => !IsLastStep;



    }
}
