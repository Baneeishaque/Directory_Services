namespace Directory_Services
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller_Directory_Services = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller_Directory_Services = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller_Directory_Services
            // 
            this.serviceProcessInstaller_Directory_Services.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller_Directory_Services.Password = null;
            this.serviceProcessInstaller_Directory_Services.Username = null;
            // 
            // serviceInstaller_Directory_Services
            // 
            this.serviceInstaller_Directory_Services.ServiceName = "Directory_Services";
            this.serviceInstaller_Directory_Services.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller_Directory_Services,
            this.serviceInstaller_Directory_Services});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller_Directory_Services;
        private System.ServiceProcess.ServiceInstaller serviceInstaller_Directory_Services;
    }
}