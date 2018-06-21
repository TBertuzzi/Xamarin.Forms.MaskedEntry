using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Xamarin.Forms.MaskedEntry
{
    public class MaskedEntry : Entry
    {
        public static readonly BindableProperty MaskProperty = 
            BindableProperty.Create(nameof(Mask), typeof(string), typeof(MaskedEntry), "");

        public string Mask
        {
            get { return GetValue(MaskProperty).ToString(); }
            set { SetValue(MaskProperty, value); }
        }

        public MaskedEntry()
        {
           
        }


        IDictionary<int, char> _positions;

        void SetPositions()
        {
            if (string.IsNullOrEmpty(Mask))
            {
                _positions = null;
                return;
            }

            var list = new Dictionary<int, char>();
            for (var i = 0; i < Mask.Length; i++)
                if (Mask[i] != 'X')
                    list.Add(i, Mask[i]);

            _positions = list;
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var entry = sender as Entry;

            var text = entry.Text;

            if (string.IsNullOrWhiteSpace(text) || _positions == null)
                return;

            if (text.Length > Mask.Length)
            {
                entry.Text = text.Remove(text.Length - 1);
                return;
            }

            foreach (var position in _positions)
                if (text.Length >= position.Key + 1)
                {
                    var value = position.Value.ToString();
                    if (text.Substring(position.Key, 1) != value)
                        text = text.Insert(position.Key, value);
                }

            if (entry.Text != text)
                entry.Text = text;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == MaskProperty.PropertyName)
            {
                SetPositions();

                this.TextChanged -= OnEntryTextChanged;

                if (!string.IsNullOrEmpty(Mask))
                {
                    this.TextChanged += OnEntryTextChanged;
                }
            }
        }
    }

}

