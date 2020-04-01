import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JScrollPane;
import javax.swing.JTable;
import java.awt.Color;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.table.DefaultTableModel;

public class PersonalContact extends JFrame {

	private JPanel contentPane;
	private JTextField tf_FirstName;
	private JTextField tf_Email;
	private JTextField tf_Addr1;
	private JTextField tf_City;
	private JTextField tf_LastName;
	private JTextField tf_Tel;
	private JTextField tf_Addr2;
	private JTextField tf_Postcode;
	private JTextField tf_HomeTel;
	private JScrollPane scrollPane;
	private JTable table;
	private JButton bt_SaveNew;
	private JButton bt_AddNew;
	private JButton bt_Updatade;
	private JButton bt_Delete;
	private JButton bt_Save;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PersonalContact frame = new PersonalContact();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public PersonalContact() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1035, 812);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		dbConn d=new dbConn();
		
		JButton bt_Refresh = new JButton("Refresh");
		bt_Refresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
			}
		});
		bt_Refresh.setBounds(924, 133, 90, 36);
		contentPane.add(bt_Refresh);
		
		tf_FirstName = new JTextField();
		tf_FirstName.setBounds(58, 43, 56, 15);
		contentPane.add(tf_FirstName);
		tf_FirstName.setColumns(10);
		
		tf_Email = new JTextField();
		tf_Email.setBounds(177, 43, 56, 15);
		contentPane.add(tf_Email);
		tf_Email.setColumns(10);
		
		tf_Addr1 = new JTextField();
		tf_Addr1.setBounds(292, 43, 56, 15);
		contentPane.add(tf_Addr1);
		tf_Addr1.setColumns(10);
		
		tf_City = new JTextField();
		tf_City.setBounds(402, 43, 56, 15);
		contentPane.add(tf_City);
		tf_City.setColumns(10);
		
		tf_LastName = new JTextField();
		tf_LastName.setBounds(58, 94, 56, 15);
		contentPane.add(tf_LastName);
		tf_LastName.setColumns(10);
		
		tf_Tel = new JTextField();
		tf_Tel.setBounds(177, 94, 56, 15);
		contentPane.add(tf_Tel);
		tf_Tel.setColumns(10);
		
		tf_Addr2 = new JTextField();
		tf_Addr2.setBounds(292, 94, 56, 15);
		contentPane.add(tf_Addr2);
		tf_Addr2.setColumns(10);
		
		tf_Postcode = new JTextField();
		tf_Postcode.setBounds(402, 94, 56, 15);
		contentPane.add(tf_Postcode);
		tf_Postcode.setColumns(10);
		
		tf_HomeTel = new JTextField();
		tf_HomeTel.setBounds(528, 43, 56, 15);
		contentPane.add(tf_HomeTel);
		tf_HomeTel.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(7, 46, 44, 9);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(7, 100, 44, 9);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Email");
		lblNewLabel_2.setBounds(139, 46, 31, 9);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Telephone");
		lblNewLabel_3.setBounds(121, 97, 49, 9);
		contentPane.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Address 1");
		lblNewLabel_4.setBounds(240, 43, 47, 15);
		contentPane.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Address 2");
		lblNewLabel_5.setBounds(240, 94, 45, 12);
		contentPane.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("City");
		lblNewLabel_6.setBounds(368, 46, 31, 9);
		contentPane.add(lblNewLabel_6);
		
		JLabel lblNewLabel_7 = new JLabel("Postcode");
		lblNewLabel_7.setBounds(364, 97, 31, 9);
		contentPane.add(lblNewLabel_7);
		
		JLabel lblNewLabel_8 = new JLabel("Home Telephone");
		lblNewLabel_8.setBounds(465, 40, 56, 20);
		contentPane.add(lblNewLabel_8);
		
		scrollPane = new JScrollPane();
		scrollPane.addMouseListener(new MouseAdapter() {	
		});
		scrollPane.setBounds(58, 181, 743, 536);
		contentPane.add(scrollPane);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {
				tf_FirstName.setText(table.getValueAt(table.getSelectedRow(),1).toString());
				tf_LastName.setText(table.getValueAt(table.getSelectedRow(),2).toString());
				tf_Email.setText(table.getValueAt(table.getSelectedRow(),3).toString());
				tf_Tel.setText(table.getValueAt(table.getSelectedRow(),4).toString());
				tf_Addr1.setText(table.getValueAt(table.getSelectedRow(),5).toString());
				tf_Addr2.setText(table.getValueAt(table.getSelectedRow(),6).toString());
				tf_City.setText(table.getValueAt(table.getSelectedRow(),7).toString());
				tf_Postcode.setText(table.getValueAt(table.getSelectedRow(),8).toString());
				tf_HomeTel.setText(table.getValueAt(table.getSelectedRow(),9).toString());
			}
		});
		scrollPane.setViewportView(table);
		
		bt_SaveNew = new JButton("Save New");
		bt_SaveNew.setEnabled(false);
		bt_SaveNew.setBounds(924, 83, 90, 36);
		contentPane.add(bt_SaveNew);
		
		bt_AddNew = new JButton("Add New");
		bt_AddNew.setBounds(922, 35, 92, 31);
		contentPane.add(bt_AddNew);
		
		bt_Updatade = new JButton("Update Selected");
		bt_Updatade.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				bt_SaveNew.setEnabled(false);
				bt_AddNew.setEnabled(false);
				bt_Delete.setEnabled(false);
				bt_Save.setEnabled(true);
			}
		});
		bt_Updatade.setBounds(801, 35, 92, 31);
		contentPane.add(bt_Updatade);
		
		bt_Delete = new JButton("Delete Selected");
		bt_Delete.setBounds(801, 94, 92, 31);
		contentPane.add(bt_Delete);
		
		bt_Save = new JButton("Save Selected");
		bt_Save.setEnabled(false);
		bt_Save.setBounds(801, 70, 92, 23);
		contentPane.add(bt_Save);
	}
}
