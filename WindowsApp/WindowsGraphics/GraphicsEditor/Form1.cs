namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnFileClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Text = ofd.FileName;
            }
        }

        private void OnToolsColorClick(object sender, EventArgs e)
        {
            ColorDialog ofd = new ColorDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Color mySelectdColor = ofd.Color;
                this.Text = mySelectdColor.ToString();
            }

        }

        private void OnShapeLine(object sender, EventArgs e)
        {
          
        }

        private void OnShapeRectangle(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(Color.Blue, 3);
           
            Point pt2 = new Point(300, 300);
            g.DrawRectangle(thePen, pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y);


        }

        private void OnShapeEllipse(object sender, EventArgs e)
        {

        }

        private Point pt1;
        private Point pt2;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
             pt1 = new Point(e.X,e.Y);

        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
           pt2 = new Point(e.X, e.Y);

            Graphics g = this.CreateGraphics();
            Pen thePen = new Pen(Color.Blue, 3);
          
            g.DrawLine(thePen, pt1, pt2);

        }
    }
}