package exceptionhandling;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;

/**
 * Exception handling example.
 * Look at the commit history to see different versions of handling
 * exceptions (they are listed as examples).
 */
public class Form1 extends JFrame {

    private JTextField num1Input;
    private JTextField num2Input;
    private JTextField resultBox;
    private JButton button1;
    private JLabel label1;
    private JLabel label2;

    public Form1() {
        initializeComponent();
    }

    private void initializeComponent() {
        button1 = new JButton("divide");
        num1Input = new JTextField();
        num2Input = new JTextField();
        resultBox = new JTextField();
        label1 = new JLabel("/");
        label2 = new JLabel("=");

        setTitle("Exception Handling");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(600, 220);
        setLayout(null);

        num1Input.setBounds(48, 53, 125, 27);
        add(num1Input);

        label1.setBounds(179, 56, 15, 20);
        add(label1);

        num2Input.setBounds(200, 53, 125, 27);
        add(num2Input);

        label2.setBounds(331, 56, 19, 20);
        add(label2);

        resultBox.setBounds(356, 53, 125, 27);
        add(resultBox);

        button1.setBounds(49, 120, 94, 29);
        button1.addActionListener(this::button1_Click);
        add(button1);
    }

    public void divide() {
        int num1, num2, result;
        try {
            num1 = Integer.parseInt(num1Input.getText());
        } catch (NumberFormatException e) {
            resultBox.setText("Invalid Entry1");
            return;
        }
        try {
            num2 = Integer.parseInt(num2Input.getText());
        } catch (NumberFormatException e) {
            resultBox.setText("Invalid Entry2");
            return;
        }
        try {
            result = num1 / num2;
        } catch (ArithmeticException e) {
            resultBox.setText("Cannot divide by zero");
            IllegalStateException ex = new IllegalStateException(
                    "you tried to divide " + num1 + " by " + num2);
            throw ex;
        }
        result = num1 / num2;
        resultBox.setText(String.valueOf(result));
    }

    private void button1_Click(ActionEvent e) {
        try {
            divide();
        } catch (IllegalStateException ex) {
            JOptionPane.showMessageDialog(this, "An error occured " + ex.getMessage());
        }
    }
}
