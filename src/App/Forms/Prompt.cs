using System.Windows.Forms;

namespace AzureTokenMaker.App.Forms {
    static class Prompt {
        public static string ShowDialog ( string text, string caption, string defaultValue = null ) {
            var prompt = new Form
                {
                    Width = 500,
                    Height = 170,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
            var textLabel = new Label() {
                Left = 50,
                Top = 20,
                Text = text,
                AutoSize =  true
            };
            var textBox = new TextBox() {
                Left = 50,
                Top = 50,
                Width = 400,
                Text = defaultValue
            };
            var confirmation = new Button() {
                Text = "Ok",
                Left = 350,
                Width = 100,
                Top = 80,
                DialogResult = DialogResult.OK
            };
            confirmation.Click += ( sender, e ) => prompt.Close();
            prompt.Controls.Add( textBox );
            prompt.Controls.Add( confirmation );
            prompt.Controls.Add( textLabel );
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
