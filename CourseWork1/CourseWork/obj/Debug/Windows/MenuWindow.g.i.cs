#pragma checksum "..\..\..\Windows\MenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D5495EA2AE24388EB47EADC016D2529F62372CE032F88F46E7069D4F11ECB2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseWork.Windows;
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


namespace CourseWork.Windows {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Windows\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YourPhotoBtn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangePasBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPhotoBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdminPanelBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseWork;component/windows/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MenuWindow.xaml"
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
            this.YourPhotoBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Windows\MenuWindow.xaml"
            this.YourPhotoBtn.Click += new System.Windows.RoutedEventHandler(this.YourPhotoBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangePasBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Windows\MenuWindow.xaml"
            this.ChangePasBtn.Click += new System.Windows.RoutedEventHandler(this.ChangePasBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddPhotoBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Windows\MenuWindow.xaml"
            this.AddPhotoBtn.Click += new System.Windows.RoutedEventHandler(this.AddPhotoBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AdminPanelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Windows\MenuWindow.xaml"
            this.AdminPanelBtn.Click += new System.Windows.RoutedEventHandler(this.AdminPanelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Windows\MenuWindow.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

