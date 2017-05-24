using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Schemas {

    
    
    public partial class FileRepository : IRepositoryHandler {
        
        static string formatPattern = "{0}{1}{2}~{3}";

        public override void InstallPackage(Upset package) {
            string sourcePath = String.Format(formatPattern, this.Path, System.IO.Path.DirectorySeparatorChar, package.PackageName, package.PackageVersion);
            
            string destination = String.Format(formatPattern, installPath, System.IO.Path.DirectorySeparatorChar, package.PackageName, package.PackageVersion);
                
            try {
                FileSystemUtil.copyDirectory(sourcePath, destination);
            } catch (DirectoryNotFoundException) {
                Debug.LogError(String.Format("Package {0} not found in specified version {1}", package.PackageName, package.PackageVersion));
                Directory.Delete(destination);
            }

        }

        public override Upset[] ListPackages() {
            string[] directories =  Directory.GetDirectories(this.Path);
            List<Upset> upsetList = new List<Upset>();

            foreach(string directoryName in directories) {
                string upsetPath = directoryName + System.IO.Path.DirectorySeparatorChar + Repository.UpsetFile;
                if(File.Exists(upsetPath)) {
                    XmlSerializer serializer = new XmlSerializer(typeof(Schemas.Upset));
                    FileStream file = new FileStream(upsetPath, FileMode.Open);
                    Upset upset = serializer.Deserialize(file) as Upset;
                    file.Close();
                    upsetList.Add(upset);
                }
                
            }

            return upsetList.ToArray();
        }

        public override void NukePackage(Upset package)
        {
            throw new NotImplementedException();
        }

        public override void NukeAllPackages() {
            string[] directories = Directory.GetDirectories(installPath);

            foreach(string dir in directories) {
                Directory.Delete(dir, true);
            }
        }

        public override void UninstallPackage(Upset package)
        {
            throw new NotImplementedException();
        }

        public override void UpdatePackage(Upset package)
        {
            throw new NotImplementedException();
        }
    }
}