using System;
using System.Collections.Generic;
using System.Windows.Forms;
using examples.Polimorfizm;
using examples.Inheritance;
using examples.Interface;
using examples.Encapsulation;
using Calculator = examples.Encapsulation.Calculator;

namespace examples
{
    public partial class frmExample : Form
    {
        public frmExample()
        {
            InitializeComponent();
        }

        /*
         * This code was created on @kaynakkodum
         */
        private float number1 = 0f;
        private float number2 = 0f;
        private void button1_Click(object sender, EventArgs e)
        {
            Polimorfizm_Main animal = new Polimorfizm_Animals(txtPolAnimalName.Text);
            richTextBox1.Text += animal.GetAnimalSound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(float.TryParse(txtPolCalcNum1.Text,out number1))
            {
                if(float.TryParse(txtPolCalcNum2.Text,out number2))
                {
                    Polimorfizm_Main calc = new Polimorfizm_Calc(number1, number2, txtPolCalcName.Text);
                    richTextBox1.Text += number1 + " " + txtPolCalcName.Text + " " + number2 + " = " + calc.Calc() + "\n"; ;
                }
            }
        }

        List<Encapsulation.Animal> Animals = new List<Encapsulation.Animal>();
        List<Encapsulation.Calculator> Calcs = new List<Encapsulation.Calculator>();
        private void button4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtInheritNum1.Text, out number1))
            {
                if (float.TryParse(txtInheritNum2.Text, out number2))
                {
                    Calculator calculator = new Calculator(number1,number2,txtInheritCalcName.Text);
                    richTextBox1.Text += number1 + " " + txtInheritCalcName.Text + " " + number2 + " = " + calculator.Calc() + "\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inheritance.Animal animal = new Inheritance.Animal(txtInheritAnimalName.Text);
            richTextBox1.Text += animal.GetAnimalSound();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Animals.Add(new Encapsulation.Animal(txtEncapsulationAnimalName.Text, txtEncapsulationAnimalSound.Text));
            MessageBox.Show($"Hayvanlar listesine bir adet hayvan eklendi : \n{txtEncapsulationAnimalName.Text} : {txtEncapsulationAnimalSound.Text}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtEncapsulationCalcNum1.Text, out number1))
            {
                if (float.TryParse(txtEncapsulationCalcNum2.Text, out number2))
                {
                    Calcs.Add(new Encapsulation.Calculator(number1, number2, txtEncapsulationCalcName.Text));
                    MessageBox.Show($"Hesap makinesi listesine bir hesap sonucu eklendi : \n" +
                                    $"{number1} {txtEncapsulationCalcName.Text} {number2} =  {Calcs[Calcs.Count - 1].TransactionResult1}");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach(Encapsulation.Animal animal in Animals)
            {
                richTextBox1.Text += $"'{animal.AnimalName_}' : " +
                                     $"{animal.AnimalSound_}\n";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach(Encapsulation.Calculator calculator in Calcs)
            {
                richTextBox1.Text += $"{calculator.Number1_} {calculator.TransactionType1_} " +
                                     $"{calculator.Number2_} = {calculator.TransactionResult1}\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Interface.Animals animals = new Interface.Animals(txtInterfaceAnimalName.Text);
            richTextBox1.Text += animals.GetAnimalSound()+"\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtInterfaceAnimalCalcNum.Text, out number1))
            {
                if (float.TryParse(txtInterfaceAnimalCalcNum2.Text, out number2))
                {
                    Interface.Calcs calcs = new Interface.Calcs(number1, number2, txtInterfaceAnimalCalcName.Text);
                    richTextBox1.Text += number1 +" "+ txtInterfaceAnimalCalcName.Text +" "+ number2 +" = " + calcs.Calc() + "\n";
                }
            }
        }
    }
}
