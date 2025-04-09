using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform;
using Avalonia.Input;
using System;
using System.IO;
using System.Collections.Generic;
using Lexer.Models;
using System.Linq;
using System.Threading.Tasks;
using Lexer.ViewModels;


namespace Lexer.Views
{
    public partial class MainWindow : Window
    {
        public Automata automata;
        public List<Token> tokens = null!;
        private string? archivoAbierto = null;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            automata = new Automata();
        }

        private void EnumerarLineas()
        {
            if (LineNumbers != null && Editor != null)
            {
                int lineCount = Editor.Text?.Split('\n').Length ?? 1;
                var lines = string.Join('\n', Enumerable.Range(1, lineCount));
                LineNumbers.Text = lines;
            }
        }

        private void Tokenizar(object? sender, Avalonia.Controls.TextChangedEventArgs e)
        {
            string input = Editor.Text ?? string.Empty;
            tokens = automata.Tokenizar(input);

            Console.WriteLine("===== TOKENS =====");
            foreach (var token in tokens)
            {
                Console.WriteLine(token.ToString());
            }
            Console.WriteLine("===== FIN =====");

            TokensGrid.Children.Clear();

            if (TokensGrid.RowDefinitions.Count == 0)
            {
                TokensGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }

            // Crear filas para los tokens
            foreach (var token in tokens)
            {
                int rowIndex = TokensGrid.RowDefinitions.Count;
                TokensGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                // Crear celdas para cada propiedad del token
                var lexemaTextBlock = new TextBlock { Text = token.Lexema };
                var tipoTextBlock = new TextBlock { Text = token.Tipo.ToString() };
                var lineaTextBlock = new TextBlock { Text = token.Linea.ToString() };
                var columnaTextBlock = new TextBlock { Text = token.Columna.ToString() };

                // Colocar cada TextBlock en el Grid en la fila correspondiente
                Grid.SetRow(lexemaTextBlock, rowIndex);
                Grid.SetColumn(lexemaTextBlock, 0);
                TokensGrid.Children.Add(lexemaTextBlock);

                Grid.SetRow(tipoTextBlock, rowIndex);
                Grid.SetColumn(tipoTextBlock, 1);
                TokensGrid.Children.Add(tipoTextBlock);

                Grid.SetRow(lineaTextBlock, rowIndex);
                Grid.SetColumn(lineaTextBlock, 2);
                TokensGrid.Children.Add(lineaTextBlock);

                Grid.SetRow(columnaTextBlock, rowIndex);
                Grid.SetColumn(columnaTextBlock, 3);
                TokensGrid.Children.Add(columnaTextBlock);
            }


            EnumerarLineas();
        }

        // Función para cargar un archivo
        private void Abrir_Click(object sender, RoutedEventArgs e)
        {
             Console.WriteLine("cargando archivo");
        }

        // Función para crear un nuevo archivo
        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
             Console.WriteLine("new");
        }

        // Función para guardar el archivo actual
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
             Console.WriteLine("save");
        }

        // Función para guardar con un nuevo nombre
        private async void GuardarComo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Guardar Como",
            };

            var filePath = await dialog.ShowAsync(this);

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    File.WriteAllText(filePath, Editor.Text);
                    Console.WriteLine($"Archivo guardado como: {filePath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No se seleccionó un archivo para guardar.");
            }
             Console.WriteLine("saveas");
        }

        // Función para copiar el texto seleccionado
        private void Copiar_Click(object sender, RoutedEventArgs e)
        {
            
             Console.WriteLine("copy");
        }

        // Función para pegar el texto en el cursor
        private void Pegar_Click(object sender, RoutedEventArgs e)
        {
             Console.WriteLine("paste");
        }

        // Función para deshacer
        private void Deshacer_Click(object sender, RoutedEventArgs e)
        {
             Console.WriteLine("undo");
        }

        // Función para rehacer
        private void Rehacer_Click(object sender, RoutedEventArgs e)
        {
             Console.WriteLine("redo");
        }

        // Función para mostrar el dialogo de "Acerca de"
        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Acercade");
        }

        // Función para preguntar si se desea guardar el archivo antes de borrar
        private void MostrarDialogoGuardar()
        {
             Console.WriteLine("Dialogosave");
        }

        private void Reporte_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
