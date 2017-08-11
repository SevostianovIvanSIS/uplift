// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Uplift.Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Upbring {
        
        private InstalledPackage[] installedPackageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstalledPackage")]
        public InstalledPackage[] InstalledPackage {
            get {
                return this.installedPackageField;
            }
            set {
                this.installedPackageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstalledPackage {
        
        private InstallSpec[] installField;
        
        private string nameField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Install")]
        public InstallSpec[] Install {
            get {
                return this.installField;
            }
            set {
                this.installField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstallSpecGUID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstallSpecPath))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class InstallSpec {
        
        private InstallSpecType typeField;
        
        private PlatformType platformField;
        
        private bool platformFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InstallSpecType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PlatformType Platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PlatformSpecified {
            get {
                return this.platformFieldSpecified;
            }
            set {
                this.platformFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    public enum InstallSpecType {
        
        /// <remarks/>
        Root,
        
        /// <remarks/>
        Base,
        
        /// <remarks/>
        Media,
        
        /// <remarks/>
        EditorPlugin,
        
        /// <remarks/>
        Plugin,
        
        /// <remarks/>
        Docs,
        
        /// <remarks/>
        Examples,
        
        /// <remarks/>
        Gizmo,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    public enum PlatformType {
        
        /// <remarks/>
        All,
        
        /// <remarks/>
        iOS,
        
        /// <remarks/>
        Android,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VersionSpec {
        
        private string itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExactVersion", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MajorVersionMax", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MajorVersionMin", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MinVersion", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        ExactVersion,
        
        /// <remarks/>
        MajorVersionMax,
        
        /// <remarks/>
        MajorVersionMin,
        
        /// <remarks/>
        MinVersion,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DependencyDefinition {
        
        private VersionSpec itemField;
        
        private string nameField;
        
        private string versionField;
        
        private string repositoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Version")]
        public VersionSpec Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Repository {
            get {
                return this.repositoryField;
            }
            set {
                this.repositoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FileRepository))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GitRepository))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebRepository))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Repository {
        
        private string extractPathField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtractPath {
            get {
                return this.extractPathField;
            }
            set {
                this.extractPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FileRepository : Repository {
        
        private string pathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GitRepository : Repository {
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRepository : Repository {
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PathConfiguration {
        
        private bool skipPackageStructureField;
        
        private bool skipPackageStructureFieldSpecified;
        
        private string locationField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SkipPackageStructure {
            get {
                return this.skipPackageStructureField;
            }
            set {
                this.skipPackageStructureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SkipPackageStructureSpecified {
            get {
                return this.skipPackageStructureFieldSpecified;
            }
            set {
                this.skipPackageStructureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Configuration {
        
        private PathConfiguration repositoryPathField;
        
        private PathConfiguration docsPathField;
        
        private PathConfiguration examplesPathField;
        
        private PathConfiguration baseInstallPathField;
        
        private PathConfiguration mediaPathField;
        
        private PathConfiguration gizmoPathField;
        
        private PathConfiguration pluginPathField;
        
        private PathConfiguration editorPluginPathField;
        
        /// <remarks/>
        public PathConfiguration RepositoryPath {
            get {
                return this.repositoryPathField;
            }
            set {
                this.repositoryPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration DocsPath {
            get {
                return this.docsPathField;
            }
            set {
                this.docsPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration ExamplesPath {
            get {
                return this.examplesPathField;
            }
            set {
                this.examplesPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration BaseInstallPath {
            get {
                return this.baseInstallPathField;
            }
            set {
                this.baseInstallPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration MediaPath {
            get {
                return this.mediaPathField;
            }
            set {
                this.mediaPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration GizmoPath {
            get {
                return this.gizmoPathField;
            }
            set {
                this.gizmoPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration PluginPath {
            get {
                return this.pluginPathField;
            }
            set {
                this.pluginPathField = value;
            }
        }
        
        /// <remarks/>
        public PathConfiguration EditorPluginPath {
            get {
                return this.editorPluginPathField;
            }
            set {
                this.editorPluginPathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstallSpecGUID : InstallSpec {
        
        private string guidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Guid {
            get {
                return this.guidField;
            }
            set {
                this.guidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstallSpecPath : InstallSpec {
        
        private string pathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Upfile {
        
        private string unityVersionField;
        
        private Configuration configurationField;
        
        private Repository[] repositoriesField;
        
        private DependencyDefinition[] dependenciesField;
        
        /// <remarks/>
        public string UnityVersion {
            get {
                return this.unityVersionField;
            }
            set {
                this.unityVersionField = value;
            }
        }
        
        /// <remarks/>
        public Configuration Configuration {
            get {
                return this.configurationField;
            }
            set {
                this.configurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(FileRepository), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(GitRepository), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(WebRepository), IsNullable=false)]
        public Repository[] Repositories {
            get {
                return this.repositoriesField;
            }
            set {
                this.repositoriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Package", IsNullable=false)]
        public DependencyDefinition[] Dependencies {
            get {
                return this.dependenciesField;
            }
            set {
                this.dependenciesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Upset {
        
        private VersionSpec unityVersionField;
        
        private string packageNameField;
        
        private string packageVersionField;
        
        private string packageLicenseField;
        
        private DependencyDefinition[] dependenciesField;
        
        private InstallSpecPath[] configurationField;
        
        /// <remarks/>
        public VersionSpec UnityVersion {
            get {
                return this.unityVersionField;
            }
            set {
                this.unityVersionField = value;
            }
        }
        
        /// <remarks/>
        public string PackageName {
            get {
                return this.packageNameField;
            }
            set {
                this.packageNameField = value;
            }
        }
        
        /// <remarks/>
        public string PackageVersion {
            get {
                return this.packageVersionField;
            }
            set {
                this.packageVersionField = value;
            }
        }
        
        /// <remarks/>
        public string PackageLicense {
            get {
                return this.packageLicenseField;
            }
            set {
                this.packageLicenseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Package", IsNullable=false)]
        public DependencyDefinition[] Dependencies {
            get {
                return this.dependenciesField;
            }
            set {
                this.dependenciesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Spec", IsNullable=false)]
        public InstallSpecPath[] Configuration {
            get {
                return this.configurationField;
            }
            set {
                this.configurationField = value;
            }
        }
    }
}
