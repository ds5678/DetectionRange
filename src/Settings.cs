using ModSettings;
using System.Collections.Generic;
using System.Reflection;

namespace DetectionRange
{
    struct AnimalRanges
    {
        public bool enabled;
        public float smell_range;

        public float hear_range;
        public float hear_range_while_feeding;

        public float detection_range;
        public float detection_range_while_feeding;
    };
    class DetectionRangeSettings : JsonModSettings
    {
        [Section("Wolf")]

        [Name("Enable override")]
        [Description("Default value is false. Note: also affects wolves' detection of rabbits and deer.")]
        public bool wolf_enabled = false;

        [Name("Smell range")]
        [Description("Default value is 100.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float wolf_smell_range = 100f;

        [Name("Hear range")]
        [Description("Default value is 60.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float wolf_hear_range = 60f;

        [Name("Hear range while feeding")]
        [Description("Default value is 25.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float wolf_hear_range_while_feeding = 25f;

        [Name("Detection range")]
        [Description("Default value is 75.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float wolf_detection_range = 75f;

        [Name("Detection range while feeding")]
        [Description("Default value is 20.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float wolf_detection_range_while_feeding = 20f;

        [Section("Deer")]

        [Name("Enable override")]
        [Description("Default value is false")]
        public bool deer_enabled = false;

        [Name("Smell range")]
        [Description("Default value is 0.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float deer_smell_range = 0f;

        [Name("Hear range")]
        [Description("Default value is 60.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float deer_hear_range = 60f;

        [Name("Hear range while feeding")]
        [Description("Default value is 20.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float deer_hear_range_while_feeding = 20f;

        [Name("Detection range")]
        [Description("Default value is 40.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float deer_detection_range = 40f;

        [Name("Detection range while feeding")]
        [Description("Default value is 30.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float deer_detection_range_while_feeding = 30f;

        [Section("Moose")]

        [Name("Enable override")]
        [Description("Default value is false")]
        public bool moose_enabled = false;

        [Name("Smell range")]
        [Description("Default value is 0.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float moose_smell_range = 0f;

        [Name("Hear range")]
        [Description("Default value is 60.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float moose_hear_range = 60f;

        [Name("Hear range while feeding")]
        [Description("Default value is 20.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float moose_hear_range_while_feeding = 20f;

        [Name("Detection range")]
        [Description("Default value is 50.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float moose_detection_range = 50f;

        [Name("Detection range while feeding")]
        [Description("Default value is 30.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float moose_detection_range_while_feeding = 30f;

        [Section("Rabbit")]

        [Name("Enable override")]
        [Description("Default value is false")]
        public bool rabbit_enabled = false;

        [Name("Smell range")]
        [Description("Default value is 0.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float rabbit_smell_range = 0f;

        [Name("Hear range")]
        [Description("Default value is 7.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float rabbit_hear_range = 7f;

        [Name("Hear range while feeding")]
        [Description("Default value is 5.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float rabbit_hear_range_while_feeding = 5f;

        [Name("Detection range")]
        [Description("Default value is 12.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float rabbit_detection_range = 12f;

        [Name("Detection range while feeding")]
        [Description("Default value is 30.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float rabbit_detection_range_while_feeding = 30f;

        [Section("Bear")]

        [Name("Enable override")]
        [Description("Default value is false")]
        public bool bear_enabled = false;

        [Name("Smell range")]
        [Description("Default value is 150.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float bear_smell_range = 150f;

        [Name("Hear range")]
        [Description("Default value is 60.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float bear_hear_range = 60f;

        [Name("Hear range while feeding")]
        [Description("Default value is 25.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float bear_hear_range_while_feeding = 25f;

        [Name("Detection range")]
        [Description("Default value is 60.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float bear_detection_range = 60f;

        [Name("Detection range while feeding")]
        [Description("Default value is 15.\n(as of 15/03/2021)")]
        [Slider(0f, 400f, 401)]
        public float bear_detection_range_while_feeding = 15f;

        protected void SetWolfVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("wolf_smell_range"), visible);
            this.SetFieldVisible(GetType().GetField("wolf_hear_range"), visible);
            this.SetFieldVisible(GetType().GetField("wolf_hear_range_while_feeding"), visible);
            this.SetFieldVisible(GetType().GetField("wolf_detection_range"), visible);
            this.SetFieldVisible(GetType().GetField("wolf_detection_range_while_feeding"), visible);
        }

        protected void SetDeerVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("deer_smell_range"), visible);
            this.SetFieldVisible(GetType().GetField("deer_hear_range"), visible);
            this.SetFieldVisible(GetType().GetField("deer_hear_range_while_feeding"), visible);
            this.SetFieldVisible(GetType().GetField("deer_detection_range"), visible);
            this.SetFieldVisible(GetType().GetField("deer_detection_range_while_feeding"), visible);
        }

        protected void SetMooseVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("moose_smell_range"), visible);
            this.SetFieldVisible(GetType().GetField("moose_hear_range"), visible);
            this.SetFieldVisible(GetType().GetField("moose_hear_range_while_feeding"), visible);
            this.SetFieldVisible(GetType().GetField("moose_detection_range"), visible);
            this.SetFieldVisible(GetType().GetField("moose_detection_range_while_feeding"), visible);
        }

        protected void SetRabbitVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("rabbit_smell_range"), visible);
            this.SetFieldVisible(GetType().GetField("rabbit_hear_range"), visible);
            this.SetFieldVisible(GetType().GetField("rabbit_hear_range_while_feeding"), visible);
            this.SetFieldVisible(GetType().GetField("rabbit_detection_range"), visible);
            this.SetFieldVisible(GetType().GetField("rabbit_detection_range_while_feeding"), visible);
        }

        protected void SetBearVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("bear_smell_range"), visible);
            this.SetFieldVisible(GetType().GetField("bear_hear_range"), visible);
            this.SetFieldVisible(GetType().GetField("bear_hear_range_while_feeding"), visible);
            this.SetFieldVisible(GetType().GetField("bear_detection_range"), visible);
            this.SetFieldVisible(GetType().GetField("bear_detection_range_while_feeding"), visible);
        }

        internal void UpdateVisibility()
        {
            SetWolfVisibility(wolf_enabled);
            SetDeerVisibility(deer_enabled);
            SetMooseVisibility(moose_enabled);
            SetRabbitVisibility(rabbit_enabled);
            SetBearVisibility(bear_enabled);
        }

        public AnimalRanges GetWolfSettings()
        {
            return new AnimalRanges
            {
                enabled = wolf_enabled,
                smell_range = wolf_smell_range,
                hear_range = wolf_hear_range,
                hear_range_while_feeding = wolf_hear_range_while_feeding,
                detection_range = wolf_detection_range,
                detection_range_while_feeding = wolf_detection_range_while_feeding
            };
        }

        public AnimalRanges GetDeerSettings()
        {
            return new AnimalRanges
            {
                enabled = deer_enabled,
                smell_range = deer_smell_range,
                hear_range = deer_hear_range,
                hear_range_while_feeding = deer_hear_range_while_feeding,
                detection_range = deer_detection_range,
                detection_range_while_feeding = deer_detection_range_while_feeding
            };
        }

        public AnimalRanges GetMooseSettings()
        {
            return new AnimalRanges
            {
                enabled = moose_enabled,
                smell_range = moose_smell_range,
                hear_range = moose_hear_range,
                hear_range_while_feeding = moose_hear_range_while_feeding,
                detection_range = moose_detection_range,
                detection_range_while_feeding = moose_detection_range_while_feeding
            };
        }

        public AnimalRanges GetRabbitSettings()
        {
            return new AnimalRanges
            {
                enabled = rabbit_enabled,
                smell_range = rabbit_smell_range,
                hear_range = rabbit_hear_range,
                hear_range_while_feeding = rabbit_hear_range_while_feeding,
                detection_range = rabbit_detection_range,
                detection_range_while_feeding = rabbit_detection_range_while_feeding
            };
        }

        public AnimalRanges GetBearSettings()
        {
            return new AnimalRanges
            {
                enabled = bear_enabled,
                smell_range = bear_smell_range,
                hear_range = bear_hear_range,
                hear_range_while_feeding = bear_hear_range_while_feeding,
                detection_range = bear_detection_range,
                detection_range_while_feeding = bear_detection_range_while_feeding
            };
        }

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            base.OnChange(field, oldValue, newValue);
            if (field.Name == "wolf_enabled") SetWolfVisibility((bool)newValue);
            else if (field.Name == "deer_enabled") SetDeerVisibility((bool)newValue);
            else if (field.Name == "moose_enabled") SetMooseVisibility((bool)newValue);
            else if (field.Name == "rabbit_enabled") SetRabbitVisibility((bool)newValue);
            else if (field.Name == "bear_enabled") SetBearVisibility((bool)newValue);
        }
        protected override void OnConfirm()
        {
            base.OnConfirm();
            DetectionRange.Settings.m_animals["wolf"] = GetWolfSettings();
            DetectionRange.Settings.m_animals["deer"] = GetDeerSettings();
            DetectionRange.Settings.m_animals["moose"] = GetMooseSettings();
            DetectionRange.Settings.m_animals["rabbit"] = GetRabbitSettings();
            DetectionRange.Settings.m_animals["bear"] = GetBearSettings();
        }
    }



    internal class Settings
    {
        internal static Dictionary<string, AnimalRanges> m_animals = new Dictionary<string, AnimalRanges>();
        internal static DetectionRangeSettings options;
        static public void OnLoad()
        {
            options = new DetectionRangeSettings();
            options.AddToModSettings("Detection Range");
            options.UpdateVisibility();
            m_animals.Add("wolf", options.GetWolfSettings());
            m_animals.Add("deer", options.GetDeerSettings());
            m_animals.Add("moose", options.GetMooseSettings());
            m_animals.Add("rabbit", options.GetRabbitSettings());
            m_animals.Add("bear", options.GetBearSettings());
        }

        static AnimalRanges GetEmptyStructure()
        {
            return new AnimalRanges
            {
                enabled = false,
                smell_range = 0f,
                hear_range = 0f,
                hear_range_while_feeding = 0f,
                detection_range = 0f,
                detection_range_while_feeding = 0f
            };
        }
    }
}
