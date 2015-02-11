using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using MalikP.Controls.Loaders;
using MalikP.Controls.Win32Api;

namespace MalikP.Controls
{
    public class LoaderUtil
    {
        //  [Obsolete("Old...Use 'LoaderExecutionChanged' event instead of this delegate")]
        public delegate void ControlHandler(bool value);
        public event Action<bool> LoaderExecutionChanged;

        public void OnLoaderExecutionChange(bool value)
        {
            var temp = LoaderExecutionChanged;
            if (temp != null)
                temp(value);
        }

        private Control _controlWhereWaiterBeAdded;

        public Point? DrawLocation { get; private set; }

        public static LoaderVersion Version { get; set; }

        public string GetLoaderVersionDescription(LoaderVersion version)
        {
            return EnumUtils<LoaderVersion>.GetDescription(version);
        }

        public static LoaderVersion GetVersion(string value)
        {
            switch (value)
            {
                case "Black":
                    return LoaderVersion.BlackAndWhite;
                case "Color":
                    return LoaderVersion.Color;
                case "Cat":
                    return LoaderVersion.Cat;
                case "Duck":
                    return LoaderVersion.Duck;
                case "Dragon":
                    return LoaderVersion.Dragon;
                case "Color1":
                    return LoaderVersion.Color1;
                default:
                    return LoaderVersion.Unknown;
            }
        }

        private UserControl _waitControl;

        public Boolean CustomLocation { get; private set; }

        public ILoader Loader
        {
            get
            {
                if (_waitControl == null) _waitControl = GetLoader(Version);
                return (ILoader)_waitControl;
            }
        }

        [Obsolete("Call Loader property", true)]
        public bool ResetText()
        {
            if (_waitControl != null)
                return Loader.Reset();

            return false;
        }

        [Obsolete("Call Loader property", true)]
        public bool SetLoaderText(string text)
        {
            if (_waitControl == null)
            {
                _waitControl = GetLoader(Version);

                return Loader.ChangeText(text);
            }
            return false;
        }

        public LoaderUtil(Control form, LoaderVersion version, ControlHandler handler)
            : this(form, handler)
        {
            Version = version;
        }

        public LoaderUtil(Control form, ControlHandler handler)
        {
            ReSetLoader(form, handler);
        }

        public LoaderUtil(Control form, LoaderVersion version, Point? drawLocation)
            : this(form, drawLocation)
        {
            Version = version;
        }

        public LoaderUtil(Control form, Point? drawLocation)
            : this(form, (ControlHandler)null)
        {
            DrawLocation = drawLocation;
            CustomLocation = true;
        }

        public void ReSetLoader(Control form, ControlHandler handler)
        {
            this._controlWhereWaiterBeAdded = form;
            if (handler != null)
                this.LoaderExecutionChanged += new Action<bool>(handler);
        }

        public LoaderUtil(Control form)
            : this(form, (ControlHandler)null)
        {
        }

        public void ExecuteLoader(bool value)
        {
            ExecuteLoader(value, false);
        }

        public void ExecuteLoader(bool value, bool destroy)
        {
            if (value)
            {
                if (_waitControl == null)
                    _waitControl = GetLoader(Version);

                SetTargetControlLocationToCenter();

                _controlWhereWaiterBeAdded.Controls.Add(_waitControl);
                _controlWhereWaiterBeAdded.Controls.SetChildIndex(_waitControl, 0);
            }
            else
            {
                _controlWhereWaiterBeAdded.Controls.Remove(_waitControl);
                if (destroy) _waitControl = null;
            }
            OnLoaderExecutionChange(value);
        }

        private void SetTargetControlLocationToCenter()
        {
            if (!CustomLocation)
            {
                var metrics = Win32Helper.GetMetrics();
                DrawLocation = new Point((_controlWhereWaiterBeAdded.Width - _waitControl.Width) / 2, ((_controlWhereWaiterBeAdded.Height - _waitControl.Height) / 2) - metrics.iMenuHeight);
            }
            _waitControl.Location = (Point)DrawLocation;
        }

        public UserControl GetLoader(LoaderVersion version)
        {
            switch (version)
            {
                case LoaderVersion.Color:
                    {
                        var ctrl = new LoadScreenColor();
                        return ctrl;
                    }
                case LoaderVersion.Color1:
                    {
                        var ctrl = new LoadScreenColor1();
                        return ctrl;
                    }
                case LoaderVersion.Cat:
                    {
                        var ctrl = new LoadScreenCat();
                        return ctrl;
                    }
                case LoaderVersion.Duck:
                    {
                        var ctrl = new LoadScreenDuck();
                        return ctrl;
                    }
                case LoaderVersion.Dragon:
                    {
                        var ctrl = new LoadScreenDragon();
                        return ctrl;
                    }
                case LoaderVersion.BlackAndWhite:
                case LoaderVersion.Unknown:
                default:
                    {
                        var ctrl = new LoadScreenBlack();
                        return ctrl;
                    }
            }
        }

        public static void SetVersion(LoaderVersion version)
        {
            SetVersion(version.ToString());
        }

        public static void SetVersion(string value)
        {
            Version = GetVersion(value);
        }

        public void SetDrawLocation(Point drawLocation)
        {
            DrawLocation = drawLocation;
            CustomLocation = true;
        }
    }
}
