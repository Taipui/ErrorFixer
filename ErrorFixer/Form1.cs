namespace ErrorFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessButton.Enabled = false;
        }

        private void FolderSelectionButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                Description = "Unityのプロジェクトのフォルダーを指定してください"
            };

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                PathLabel.Text = fbd.SelectedPath;
                ProcessButton.Enabled = true;
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            var folderPath = PathLabel.Text;

            var filePath = $"{folderPath}\\Packages\\com.vrchat.base\\Editor\\VRCSDK\\Dependencies\\VRChat\\EnvConfig.cs";
            if (!File.Exists(filePath))
            {
                MessageLabel.Text = $"ファイルが存在しません: {filePath}";
                return;
            }

            var content = File.ReadAllText(filePath);

            // SetVirtualRealitySDKsをコメントアウトする.
            content = content.Replace("PlayerSettings.SetVirtualRealitySDKs(buildTargetGroup, sdkNames);", "//PlayerSettings.SetVirtualRealitySDKs(buildTargetGroup, sdkNames);");

            // il2CppAdditionalArgs.Addをコメントアウトする.
            content = content.Replace("il2CppAdditionalArgs.Add(\"--generic-virtual-method-iterations=2\");", "//il2CppAdditionalArgs.Add(\"--generic-virtual-method-iterations=2\");");

            File.WriteAllText(filePath, content);

            // VRCAvatarParameterDriverEditorのusingを変更する.
            filePath = $"{folderPath}\\Packages\\com.vrchat.avatars\\Editor\\VRCSDK\\SDK3A\\Components3\\VRCAvatarParameterDriverEditor.cs";
            if (!File.Exists(filePath))
            {
                MessageLabel.Text = $"ファイルが存在しません: {filePath}";
                return;
            }

            content = File.ReadAllText(filePath);
            content = content.Replace("using Boo.Lang;", "//using Boo.Lang;\nusing System.Collections.Generic;");
            File.WriteAllText(filePath, content);

            MessageLabel.Text = "完了しました";
        }
    }
}