using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;
//using KnToolsHulft;
//using KnToolsHulft.Data;

namespace KnToolsHulftJpMon
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //
            this.HulftBookFolder.Text = Directory.GetCurrentDirectory();

        }

        private void OnMenuExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void OnMenuStandard(object sender, RoutedEventArgs e)
        {
            //((MenuItem)ScientificMenu).IsChecked = false;
            StandardMenu.IsChecked = true; //for now always Standard
        }

        private void OnMenuAbout(object sender, RoutedEventArgs e)
        {
            //var parent = (Window)MyPanel.Parent;
            //MessageBox.Show(parent, parent.Title + " - By Jossef Goldberg ", parent.Title, MessageBoxButton.OK,
            //  MessageBoxImage.Information);

            var _childWindow = new About();

            // Show the window
            //_childWindow.Show();
            _childWindow.ShowDialog();


        }


        /// <summary>
        /// クリックされて、ExcelBookファイルを作成するフォルダを指定するメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_SelectHulftBookFolder(object sender, RoutedEventArgs e)
        {
            OpenDocumentHulftBookFolder();
        }


        private void OpenDocumentHulftBookFolder()
        {
            try
            {
                // テキストボックスからファイル名 (ファイルパス) を取得
                string fileName = this.HulftBookFolder.Text;

                // OpenFileDialog クラスのインスタンスを生成
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.FileName = "hulftBookFolder";
                    //openFileDialog.DefaultExt = ".xlsx";
                    openFileDialog.CheckFileExists = false;     //存在しなくも良いを指定

                    // ファイルの種類リストを設定
                    //openFileDialog.Filter = "HultBook(.xlsx)|*.xlsx";

                    // テキストボックスにファイル名 (ファイルパス) が設定されている場合は
                    // ファイルのディレクトリー (フォルダー) を初期表示する
                    if (fileName != string.Empty)
                    {
                        // FileInfo クラスのインスタンスを生成
                        FileInfo fileInfo = new FileInfo(fileName);
                        // ディレクトリー名 (ディレクトリーパス) を取得
                        string directoryName = fileInfo.DirectoryName;
                        // 存在する場合は InitialDirectory プロパティに設定
                        if (Directory.Exists(directoryName))
                        {
                            openFileDialog.InitialDirectory = directoryName;
                        }
                    }

                    // ダイアログを表示
                    DialogResult dialogResult = openFileDialog.ShowDialog();
                    if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        // キャンセルされたので終了
                        return;
                    }

                    // 選択されたファイル名 (ファイルパス) をテキストボックスに設定
                    FileInfo OpenDialogfileInfo = new FileInfo(openFileDialog.FileName);
                    this.HulftBookFolder.Text = OpenDialogfileInfo.DirectoryName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MakeKnowServers(object sender, RoutedEventArgs e)
        {
            var list = new Servers();

            if ((bool)Server1.IsChecked) { list.AddNewServer(Server1.Content.ToString()); }
            if ((bool)Server2.IsChecked) { list.AddNewServer(Server2.Content.ToString()); }
            if ((bool)Server3.IsChecked) { list.AddNewServer(Server3.Content.ToString()); }

            Debug.WriteLine(list.SeverList);

        }
    }

}
