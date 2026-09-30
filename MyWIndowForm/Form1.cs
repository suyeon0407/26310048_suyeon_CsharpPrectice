namespace MyWIndowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Button> btnList = new List<Button>();
            btnList.Add(new Button());
            btnList.Add(new Button());
            btnList.Add(new Button());
            btnList.Add(new Button());

            
            for (int i = 0; i < btnList.Count; i++)
            {
                btnList[i].Name = $"btn {i}";
                btnList[i].Text = btnList[i].Name;
                btnList[i].Width = 100;
                btnList[i].Height = 50;
                btnList[i].Location = new Point(10,10+i*60);
                btnList[i].Click += (sender, e) =>
                {
                    MessageBox.Show($"Button(BtnList[i].Name) Clicked!");

                };

                Controls.Add(btnList[i]);
            }
        }
    }
}
