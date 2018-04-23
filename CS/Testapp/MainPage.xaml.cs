using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.XtraSpellChecker;
using System.Reflection;
using System.IO;
using System.Globalization;
using DevExpress.Xpf.SpellChecker;
using Testapp.SpellChecker;

namespace Testapp {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void richEdit_Loaded(object sender, RoutedEventArgs e) {
            DevExpress.Xpf.SpellChecker.SpellChecker spellChecker = SpellCheckerHelper.SpellChecker;
            spellChecker.SpellCheckMode = SpellCheckMode.AsYouType;
            this.richEdit.SpellChecker = spellChecker;
        }
    }
}
