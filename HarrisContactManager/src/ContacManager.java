import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class ContacManager {

	private JFrame frame;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ContacManager window = new ContacManager();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ContacManager() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton bt_PersonalContact = new JButton("Personal Contact");
		bt_PersonalContact.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				PersonalContact pc=new PersonalContact();
				frame.dispose();
				pc.setVisible(true);
			}
		});
		bt_PersonalContact.setForeground(Color.WHITE);
		bt_PersonalContact.setBackground(Color.BLACK);
		bt_PersonalContact.setBounds(70, 103, 93, 41);
		frame.getContentPane().add(bt_PersonalContact);
		
		JButton bt_BusinessContact = new JButton("Business Contact");
		bt_BusinessContact.setForeground(Color.WHITE);
		bt_BusinessContact.setBackground(Color.BLACK);
		bt_BusinessContact.setBounds(254, 103, 91, 41);
		frame.getContentPane().add(bt_BusinessContact);
	}
}
