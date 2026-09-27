using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using SkyrimPresetGenerator.Models;
using SkyrimPresetGenerator.Services;


namespace SkyrimPresetGenerator
{
    public partial class MainWindow : Window
    {

        // TODO: add button to reroll certain things (or groups?)
        // TODO: add a save or favorite funtion

        // generator to create new presets
        private readonly PresetGenerator presetGenerator = new PresetGenerator();

        public MainWindow()
        {
            InitializeComponent();
        }

        // run when button is clicked
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            // get race/sex from dropdown thing
            string race = GetSelectedValue(RaceComboBox);
            string sex = GetSelectedValue(SexComboBox);

            // generate new preset with above stuff
            Preset preset = presetGenerator.Generate(race, sex);

            // display generated stuff
            RaceResult.Text = $"Race: {preset.Race}";
            SexResult.Text = $"Sex: {preset.Sex}";
            AgeResult.Text = $"Age: {preset.Age}";

            // display generated details
            FaceShapeResult.Text = $"Face Shape: {preset.FaceShape}";
            EyesResult.Text = $"Eyes: {preset.Eyes}";
            NoseResult.Text = $"Nose: {preset.Nose}";
            MouthResult.Text = $"Mouth: {preset.Mouth}";
            JawResult.Text = $"Jaw: {preset.Jaw}";
            ComplexionResult.Text = $"Complexion: {preset.Complexion}";
            DistinctiveFeatureResult.Text =
                $"Distinctive Feature: {preset.DistinctiveFeature}";
            BackgroundResult.Text = $"Background: {preset.Background}";
        }

        // get text stored inside combobox
        private string GetSelectedValue(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                return selectedItem.Content.ToString() ?? "";
            }

            return "";
        }
    }
}