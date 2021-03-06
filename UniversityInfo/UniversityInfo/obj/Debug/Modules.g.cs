#pragma checksum "..\..\Modules.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D6E9E656024DC4B66A891BE4FF54AEBF0C162BB5949F61359ADAA22FD3866449"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using UniversityInfo;


namespace UniversityInfo {
    
    
    /// <summary>
    /// Modules
    /// </summary>
    public partial class Modules : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModulesID;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ModulesName;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModulesNoOfHours;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModulesLecturersID;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrecedingModulesID;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ModulesDepartment;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\Modules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid StudentsTable;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UniversityInfo;component/modules.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Modules.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 32 "..\..\Modules.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ModulesIDValidation);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ModulesID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ModulesName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 67 "..\..\Modules.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ModulesIDValidation);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ModulesNoOfHours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 71 "..\..\Modules.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ModulesIDValidation);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ModulesLecturersID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 75 "..\..\Modules.xaml"
            ((System.Windows.Controls.StackPanel)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ModulesIDValidation);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PrecedingModulesID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ModulesDepartment = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            
            #line 115 "..\..\Modules.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReadModules);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 133 "..\..\Modules.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateModules);
            
            #line default
            #line hidden
            return;
            case 13:
            this.StudentsTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

