using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimeiroCrudWPFEF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        PRODUTO prod = new PRODUTO();
        CATEGORIA cat = new CATEGORIA();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrarCategoria_Click(object sender, RoutedEventArgs e)
        {
            cat.DESCRICAO = txtDescricaoCategoria.Text;
            using (BDPRODUTOSEntities ctx = new BDPRODUTOSEntities())
            {
                ctx.CATEGORIAs.Add(cat);
                ctx.SaveChanges();
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }
            Limparcategoria();
            ListarCategorias();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ListarCategorias();
        }
        private void Limparcategoria()
        {
            txtDescricaoCategoria.Clear();
            txtIdCategoria.Clear();
        }
        private void ListarCategorias()
        {
            using(BDPRODUTOSEntities ctx = new BDPRODUTOSEntities())
            {
                var consulta = ctx.CATEGORIAs;
                categoriasCadastradas.ItemsSource = consulta.ToList();

            }
        }

        private void btnPesquisarCategoria_Click(object sender, RoutedEventArgs e)
        {
            using (BDPRODUTOSEntities ctx = new BDPRODUTOSEntities())
            {
                if (!string.IsNullOrEmpty(txtIdCategoria.Text))
                {
                    int id = int.Parse(txtIdCategoria.Text);
                    var pesquisa = ctx.CATEGORIAs.Find(id);
                    categoriasCadastradas.ItemsSource = new CATEGORIA[1] { pesquisa };
                    Limparcategoria();
                }
                if (!string.IsNullOrEmpty(txtDescricaoCategoria.Text))
                {

                    var pesquisa = from pc in ctx.CATEGORIAs
                                   where pc.DESCRICAO.Contains(txtDescricaoCategoria.Text)
                                   select pc;
                    categoriasCadastradas.ItemsSource = pesquisa.ToList();
                    Limparcategoria();
                }
            }
        }

        private void categoriasCadastradas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(categoriasCadastradas.SelectedIndex > 0)
            {
                CATEGORIA alterar = (CATEGORIA)categoriasCadastradas.SelectedItem;
                txtIdCategoria.Text = alterar.IDCATEGORIA.ToString();
                txtDescricaoCategoria.Text = alterar.DESCRICAO;
                txtIdCategoria.IsEnabled = false; 

            }
        }

        private void btnalterarCategoria_Click(object sender, RoutedEventArgs e)
        {
            using (BDPRODUTOSEntities ctx =new BDPRODUTOSEntities())
            {
                CATEGORIA cat_alterar = ctx.CATEGORIAs.Find(int.Parse(txtIdCategoria.Text));
                if (cat_alterar != null)
                {
                    cat_alterar.DESCRICAO = txtDescricaoCategoria.Text;
                    ctx.SaveChanges();
                }
                ListarCategorias();
                Limparcategoria();

                txtIdCategoria.IsEnabled = true;

            }
        }

        private void btnExcluirCategoria_Click(object sender, RoutedEventArgs e)
        {
            
            using (BDPRODUTOSEntities ctx = new BDPRODUTOSEntities())
            {
                CATEGORIA c = ctx.CATEGORIAs.Find(int.Parse(txtIdCategoria.Text));
                if(c != null)
                {
                    MessageBoxResult mbr;
                    mbr = MessageBox.Show("Tem certeze que deseja excluir essa categoria?", "Excluir Categoria", MessageBoxButton.YesNo);
                    if(mbr == MessageBoxResult.Yes)
                    {
                        ctx.CATEGORIAs.Remove(c);
                        ctx.SaveChanges();
                    }

                }
                ListarCategorias();
                Limparcategoria();
            }
        }
    }
}
