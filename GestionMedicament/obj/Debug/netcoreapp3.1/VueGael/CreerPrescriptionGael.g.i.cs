﻿#pragma checksum "..\..\..\..\VueGael\CreerPrescriptionGael.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31568DF93A7F73C3E0076624E509A7A99A086DB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionMedicament.VueGael;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GestionMedicament.VueGael {
    
    
    /// <summary>
    /// CreerPrescriptionGael
    /// </summary>
    public partial class CreerPrescriptionGael : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Graphiques;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboIndividu;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboDosage;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPosologie;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreerPrescription;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestionMedicament;component/vuegael/creerprescriptiongael.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
            ((GestionMedicament.VueGael.CreerPrescriptionGael)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 48 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.linkGstIdv_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 56 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.linkgstMedoc_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Graphiques = ((System.Windows.Controls.RadioButton)(target));
            
            #line 68 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
            this.Graphiques.Click += new System.Windows.RoutedEventHandler(this.Graphiques_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cboIndividu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cboDosage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtPosologie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnCreerPrescription = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\VueGael\CreerPrescriptionGael.xaml"
            this.btnCreerPrescription.Click += new System.Windows.RoutedEventHandler(this.btnCreerPrescription_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

