package exceptionhandling;

import javax.swing.SwingUtilities;

public class Main {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            Form1 form = new Form1();
            form.setVisible(true);
        });
    }
}
