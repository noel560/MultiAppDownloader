using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace MultiAppDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chrome_Click(object sender, EventArgs e) //chrome
        {
            string fileUrl = "https://dl.google.com/chrome/install/chrome_installer.exe";
            DownloadFile(fileUrl, "chrome_installer.exe");
        }

        private void brave_Click(object sender, EventArgs e) //brave
        {
            string fileUrl = "https://laptop-updates.brave.com/latest/winx64";
            DownloadFile(fileUrl, "BraveBrowserSetup.exe");
        }

        private void firefox_Click(object sender, EventArgs e) //firefox
        {
            string fileUrl = "https://download.mozilla.org/?product=firefox-latest&os=win64&lang=en-US";
            DownloadFile(fileUrl, "Firefox Setup 132.0.2.exe");
        }

        private void opera_Click(object sender, EventArgs e) //opera
        {
            string fileUrl = "https://net.geo.opera.com/opera/stable/windows";
            DownloadFile(fileUrl, "OperaSetup.exe");
        }

        private void steam_Click(object sender, EventArgs e) //steam
        {
            string fileUrl = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            DownloadFile(fileUrl, "SteamSetup.exe");
        }

        private void epicgames_Click(object sender, EventArgs e) //epicgames
        {
            string fileUrl = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi";
            DownloadFile(fileUrl, "EpicInstaller.msi");
        }

        private void origin_Click(object sender, EventArgs e) //origin
        {
            string fileUrl = "https://download.dm.origin.com/origin/live/OriginThinSetup.exe";
            DownloadFile(fileUrl, "OriginThinSetup.exe");
        }

        private void riotclient_Click(object sender, EventArgs e) //riotclient
        {
            string fileUrl = "https://lol.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.na.exe";
            DownloadFile(fileUrl, "RiotClient.exe");
        }

        private void blender_Click(object sender, EventArgs e) //blender
        {
            string fileUrl = "https://download.blender.org/release/Blender3.6/blender-3.6.4-windows-x64.msi";
            DownloadFile(fileUrl, "blender-3.6.4-windows-x64.msi");
        }

        private void paintnet_Click(object sender, EventArgs e) //paint.net
        {
            string fileUrl = "https://github.com/paintdotnet/release/releases/download/v5.1/paint.net.5.1.install.anycpu.web.zip";
            DownloadFile(fileUrl, "paint.net.5.1.install.anycpu.web.zip");
        }

        private void gimp_Click(object sender, EventArgs e) //gimp
        {
            string fileUrl = "https://download.gimp.org/pub/gimp/v2.10/windows/gimp-2.10.34-setup.exe";
            DownloadFile(fileUrl, "gimp-2.10.34-setup.exe");
        }

        private void avast_Click(object sender, EventArgs e) //avast
        {
            string fileUrl = "https://files.avast.com/iavs9x/avast_free_antivirus_setup_online.exe";
            DownloadFile(fileUrl, "avast_free_antivirus_setup_online.exe");
        }

        private void avg_Click(object sender, EventArgs e) //libreoffice
        {
            string fileUrl = "https://download.documentfoundation.org/libreoffice/stable/24.8.3/win/x86_64/LibreOffice_24.8.3_Win_x86-64.msi";
            DownloadFile(fileUrl, "LibreOffice_24.8.3_Win_x86-64.msi");
        }

        private void malwarebytes_Click(object sender, EventArgs e) //malwarebytes
        {
            string fileUrl = "https://downloads.malwarebytes.com/file/mb-windows";
            DownloadFile(fileUrl, "MBSetup.exe");
        }

        private void ccleaner_Click(object sender, EventArgs e) //ccleaner
        {
            string fileUrl = "https://download.ccleaner.com/ccsetup613.exe";
            DownloadFile(fileUrl, "ccsetup613.exe");
        }

        private void teamviewer_Click(object sender, EventArgs e) //teamviewer
        {
            string fileUrl = "https://download.teamviewer.com/download/TeamViewer_Setup.exe";
            DownloadFile(fileUrl, "TeamViewer_Setup.exe");
        }

        private void winrar_Click(object sender, EventArgs e) //winrar
        {
            string fileUrl = "https://www.win-rar.com/fileadmin/winrar-versions/winrar-x64-621.exe";
            DownloadFile(fileUrl, "winrar-x64-621.exe");
        }

        private void sevenzip_Click(object sender, EventArgs e) //7zip
        {
            string fileUrl = "https://www.7-zip.org/a/7z2301-x64.exe";
            DownloadFile(fileUrl, "7z2301-x64.exe");
        }

        private void discord_Click(object sender, EventArgs e) //discord
        {
            string fileUrl = "https://discord.com/api/download?platform=win";
            DownloadFile(fileUrl, "DiscordSetup.exe");
        }

        private void notepadpp_Click(object sender, EventArgs e) //notepad++
        {
            string fileUrl = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.5.6/npp.8.5.6.Installer.x64.exe";
            DownloadFile(fileUrl, "npp.8.5.6.Installer.x64.exe");
        }

        private void anydesk_Click(object sender, EventArgs e) // AnyDesk
        {
            string fileUrl = "https://download.anydesk.com/AnyDesk.exe";
            DownloadFile(fileUrl, "AnyDesk.exe");
        }

        private void eclipse_Click(object sender, EventArgs e) // Eclipse
        {
            string fileUrl = "https://ftp.yz.yamagata-u.ac.jp/pub/eclipse/oomph/epp/2023-06/R/eclipse-inst-jre-win64.exe";
            DownloadFile(fileUrl, "EclipseInstaller.exe");
        }

        private void qbittorent_Click(object sender, EventArgs e) // qBittorrent
        {
            string fileUrl = "https://sourceforge.net/projects/qbittorrent/files/qbittorrent-win32/qbittorrent-4.5.3/qbittorrent_4.5.3_x64_setup.exe";
            DownloadFile(fileUrl, "qBittorrent.exe");
        }

        private void vscode_Click(object sender, EventArgs e) // Visual Studio Code
        {
            string fileUrl = "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64";
            DownloadFile(fileUrl, "VSCodeSetup.exe");
        }

        private void winscp_Click(object sender, EventArgs e) // WinSCP
        {
            string fileUrl = "https://sourceforge.net/projects/winscp/files/WinSCP/5.21.8/WinSCP-5.21.8-Setup.exe";
            DownloadFile(fileUrl, "WinSCP.exe");
        }

        private void putty_Click(object sender, EventArgs e) // PuTTY
        {
            string fileUrl = "https://the.earth.li/~sgtatham/putty/latest/w64/putty.exe";
            DownloadFile(fileUrl, "PuTTY.exe");
        }

        private void filezilla_Click(object sender, EventArgs e) // Rufus
        {
            string fileUrl = "https://github.com/pbatard/rufus/releases/download/v4.6/rufus-4.6.exe";
            DownloadFile(fileUrl, "rufus-4.6.exe");
        }

        private void virtualbox_Click(object sender, EventArgs e) // VirtualBox
        {
            string fileUrl = "https://download.virtualbox.org/virtualbox/7.0.10/VirtualBox-7.0.10-158379-Win.exe";
            DownloadFile(fileUrl, "VirtualBox.exe");
        }

        private void mumuplayer_Click(object sender, EventArgs e) // Mumu Player
        {
            string fileUrl = "https://adl.easebar.com/d/g/mumu/c/mumuglobal?type=pc&direct=1";
            DownloadFile(fileUrl, "MuMuPlayer.exe");
        }

        private void msiafterburner_Click(object sender, EventArgs e) // MSI Afterburner
        {
            string fileUrl = "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe";
            DownloadFile(fileUrl, "jdk-21_windows-x64_bin.exe");
        }

        private void bluestacks_Click(object sender, EventArgs e) // BlueStacks
        {
            string fileUrl = "https://download.scdn.co/SpotifySetup.exe";
            DownloadFile(fileUrl, "SpotifySetup.exe");
        }

        private void vlc_Click(object sender, EventArgs e) // VLC Media Player
        {
            string fileUrl = "https://videolan.mirror.ba/vlc/3.0.18/win64/vlc-3.0.18-win64.exe";
            DownloadFile(fileUrl, "VLCMediaPlayer.exe");
        }

        private void geforce_Click(object sender, EventArgs e) // GeForce Experience
        {
            string fileUrl = "https://us.download.nvidia.com/GFE/GFEClient/3.27.0.112/GeForce_Experience_v3.27.0.112.exe";
            DownloadFile(fileUrl, "GeForceExperience.exe");
        }

        private void unity_Click(object sender, EventArgs e) // Unity
        {
            string fileUrl = "https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe";
            DownloadFile(fileUrl, "UnityHub.exe");
        }

        private void python_Click(object sender, EventArgs e) // Python
        {
            string fileUrl = "https://www.python.org/ftp/python/3.11.5/python-3.11.5-amd64.exe";
            DownloadFile(fileUrl, "PythonInstaller.exe");
        }

        private void visualstudio_Click(object sender, EventArgs e) // Visual Studio
        {
            string fileUrl = "https://aka.ms/vs/17/release/vs_community.exe";
            DownloadFile(fileUrl, "VisualStudioInstaller.exe");
        }

        private void nodejs_Click(object sender, EventArgs e) // Node.js
        {
            string fileUrl = "https://nodejs.org/dist/v18.18.0/node-v18.18.0-x64.msi";
            DownloadFile(fileUrl, "NodeJS.msi");
        }

        private void git_Click(object sender, EventArgs e) // Git
        {
            string fileUrl = "https://github.com/git-for-windows/git/releases/download/v2.42.0.windows.1/Git-2.42.0-64-bit.exe";
            DownloadFile(fileUrl, "GitInstaller.exe");
        }

        private void sublimetext_Click(object sender, EventArgs e) // Sublime Text
        {
            string fileUrl = "https://download.sublimetext.com/Sublime%20Text%20Build%203211%20x64%20Setup.exe";
            DownloadFile(fileUrl, "SublimeText.exe");
        }

        private void zoom_Click(object sender, EventArgs e) // Zoom
        {
            string fileUrl = "https://zoom.us/client/latest/ZoomInstaller.exe";
            DownloadFile(fileUrl, "ZoomInstaller.exe");
        }

        // Download Stuff
        private void DownloadFile(string fileUrl, string fileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string localPath = System.IO.Path.Combine(desktopPath, fileName);

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(fileUrl, localPath);
                    MessageBox.Show("The file has been successfully downloaded to your desktop: " + localPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

    }
}
