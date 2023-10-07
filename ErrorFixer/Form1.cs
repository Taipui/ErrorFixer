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
                PathLabel.Text        = fbd.SelectedPath;
                ProcessButton.Enabled = true;
                MessageLabel.Text     = string.Empty;
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            var folderPath = PathLabel.Text;

            if (Properties.Settings.Default.ShouldFixErrors)
            {
                FixErrors();
            }
            if (Properties.Settings.Default.ShouldFixRendering)
            {
                FixRendering();
            }

            MessageLabel.Text = "完了しました";

            void FixErrors()
            {
                var filePath = $"{folderPath}\\Packages\\com.vrchat.base\\Editor\\VRCSDK\\Dependencies\\VRChat\\EnvConfig.cs";
                if (!File.Exists(filePath))
                {
                    MessageLabel.Text = $"ファイルが存在しません: {filePath}";
                    return;
                }

                var content = File.ReadAllText(filePath);

                // SetVirtualRealitySDKsをコメントアウトする.
                content = CommentOut(content, "PlayerSettings.SetVirtualRealitySDKs(buildTargetGroup, sdkNames);");

                // il2CppAdditionalArgs.Addをコメントアウトする.
                content = CommentOut(content, "il2CppAdditionalArgs.Add(\"--generic-virtual-method-iterations=2\");");

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
            }

            void FixRendering()
            {
                // InjectStereoVariantsの一部のコードをコメントアウトする.
                var filePath = $"{folderPath}\\Packages\\com.vrchat.base\\Editor\\VRCSDK\\Dependencies\\VRChat\\ShaderStripping\\InjectStereoVariants.cs";
                if (!File.Exists(filePath))
                {
                    MessageLabel.Text = $"ファイルが存在しません: {filePath}";
                    return;
                }

                var content = File.ReadAllText(filePath);
                content = CommentOut(content, "shaderKeywordSet.Disable(_unitySinglePassStereoKeyword);");
                content = CommentOut(content, "shaderKeywordSet.Enable(_stereoInstancingKeyword);");
                content = CommentOut(content, "shaderKeywordSet.Enable(_unitySinglePassStereoKeyword);");
                content = CommentOut(content, "shaderKeywordSet.Disable(_stereoInstancingKeyword);");
                File.WriteAllText(filePath, content);
            }

            string CommentOut(string content, string code)
            {
                if (content.IndexOf($"//{code}") >= 0)
                {
                    return content;
                }

                return content.Replace(code, $"//{code}");
            }
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            var optionForm = new OptionForm();
            optionForm.ShowDialog();
        }
    }
}