# DevelopmentUtilities

This repository contains a simple Blazor Server with some utilities to make my life and work easier. I doubt this will be useful to anyone other than me but nothing wrong with sharing it, no?

## Usage

For now all the utilities work by pasting a Entity(class) into the input text-area for example:

        public int Id { get; set; }
        public string SomeRandomProp { get; set; } = null!;
        public string? smtpAddress { get; set; }
        public string? from { get; set; }
        public string? to { get; set; }
        public string? cc { get; set; }
        public string? bcc { get; set; }
        public bool useCredentials { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
        public bool EnableSSL { get; set; }
        
After pasting just press the 'Generate' button in the top right corner of the screen.

## Info

The validator utility writes FluentValidationValidators.
