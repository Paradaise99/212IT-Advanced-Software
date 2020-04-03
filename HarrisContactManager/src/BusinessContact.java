import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JScrollPane;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JTable;

public class BusinessContact extends JFrame {

	private JPanel contentPane;
	private JTextField tf_FirstName;
	private JTextField tf_Email;
	private JTextField tf_Addr1;
	private JTextField tf_City;
	private JTextField tf_LastName;
	private JTextField tf_Tel;
	private JTextField tf_Addr2;
	private JTextField tf_Postcode;
	private JTextField tf_BusinessTel;
	private JScrollPane scrollPane;
	private JButton bt_SaveNew;
	private JButton bt_AddNew;
	private JButton bt_Updatade;
	private JButton bt_Delete;
	private JButton bt_Save;
	boolean updatemode= true;
	private JTable table;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BusinessContact frame = new BusinessContact();
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
	public BusinessContact() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1004, 714);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel contentPane_1 = new JPanel();
		dbConn d=new dbConn();
		contentPane_1.setLayout(null);
		contentPane_1.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.add(contentPane_1, BorderLayout.CENTER);
		
		JButton bt_Refresh = new JButton("Refresh");
		bt_Refresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				bt_Updatade.setEnabled(false);
				bt_Save.setEnabled(false);
				bt_Delete.setEnabled(false);
				bt_SaveNew.setEnabled(true);
				bt_AddNew.setEnabled(true);
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
			}
		});
		bt_Refresh.setBounds(893, 130, 69, 17);
		contentPane_1.add(bt_Refresh);
		
		tf_FirstName = new JTextField();
		tf_FirstName.setColumns(10);
		tf_FirstName.setBounds(58, 43, 56, 15);
		contentPane_1.add(tf_FirstName);
		
		tf_Email = new JTextField();
		tf_Email.setColumns(10);
		tf_Email.setBounds(177, 43, 56, 15);
		contentPane_1.add(tf_Email);
		
		tf_Addr1 = new JTextField();
		tf_Addr1.setColumns(10);
		tf_Addr1.setBounds(292, 43, 56, 15);
		contentPane_1.add(tf_Addr1);
		
		tf_City = new JTextField();
		tf_City.setColumns(10);
		tf_City.setBounds(402, 43, 56, 15);
		contentPane_1.add(tf_City);
		
		tf_LastName = new JTextField();
		tf_LastName.setColumns(10);
		tf_LastName.setBounds(58, 94, 56, 15);
		contentPane_1.add(tf_LastName);
		
		tf_Tel = new JTextField();
		tf_Tel.setColumns(10);
		tf_Tel.setBounds(177, 94, 56, 15);
		contentPane_1.add(tf_Tel);
		
		tf_Addr2 = new JTextField();
		tf_Addr2.setColumns(10);
		tf_Addr2.setBounds(292, 94, 56, 15);
		contentPane_1.add(tf_Addr2);
		
		tf_Postcode = new JTextField();
		tf_Postcode.setColumns(10);
		tf_Postcode.setBounds(402, 94, 56, 15);
		contentPane_1.add(tf_Postcode);
		
		tf_BusinessTel = new JTextField();
		tf_BusinessTel.setColumns(10);
		tf_BusinessTel.setBounds(511, 43, 56, 15);
		contentPane_1.add(tf_BusinessTel);
		
		JLabel lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(20, 46, 31, 9);
		contentPane_1.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(20, 100, 31, 9);
		contentPane_1.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Email");
		lblNewLabel_2.setBounds(139, 46, 31, 9);
		contentPane_1.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Telephone");
		lblNewLabel_3.setBounds(139, 97, 31, 9);
		contentPane_1.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Address 1");
		lblNewLabel_4.setBounds(256, 49, 31, 9);
		contentPane_1.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Address 2");
		lblNewLabel_5.setBounds(254, 97, 31, 9);
		contentPane_1.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("City");
		lblNewLabel_6.setBounds(368, 46, 31, 9);
		contentPane_1.add(lblNewLabel_6);
		
		JLabel lblNewLabel_7 = new JLabel("Postcode");
		lblNewLabel_7.setBounds(364, 97, 31, 9);
		contentPane_1.add(lblNewLabel_7);
		
		JLabel lblNewLabel_8 = new JLabel("Business Telephone");
		lblNewLabel_8.setBounds(473, 46, 31, 9);
		contentPane_1.add(lblNewLabel_8);
		
		JButton bt_AddNew = new JButton("Add New");
		bt_AddNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				updatemode = false;
				bt_Updatade.setEnabled(false);
				bt_Save.setEnabled(false);
				bt_Delete.setEnabled(false);
				bt_SaveNew.setEnabled(true);
				bt_AddNew.setEnabled(true);
			}
		});
		bt_AddNew.setBounds(893, 42, 69, 17);
		contentPane_1.add(bt_AddNew);
		
		JButton bt_SaveNew = new JButton("Save New");
		bt_SaveNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				if(updatemode == true) {
					String f=tf_FirstName.getText();
					String l=tf_LastName.getText();
					String em=tf_Email.getText();
					String t=tf_Tel.getText();
					String a1=tf_Addr1.getText();
					String a2=tf_Addr2.getText();
					String c=tf_City.getText();
					String p=tf_Postcode.getText();
					String bt=tf_BusinessTel.getText();
					d.InsertBusiness(f, l, em, t, a1, a2, c, p, bt);
					table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
				}
					else {
						String f=tf_FirstName.getText();
						String l=tf_LastName.getText();
						String em=tf_Email.getText();
						String t=tf_Tel.getText();
						String a1=tf_Addr1.getText();
						String a2=tf_Addr2.getText();
						String c=tf_City.getText();
						String p=tf_Postcode.getText();
						String bt=tf_BusinessTel.getText();
						d.InsertBusiness(f, l, em, t, a1, a2, c, p, bt);
						table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
					}
			}
		});
		bt_SaveNew.setBounds(893, 80, 69, 17);
		contentPane_1.add(bt_SaveNew);
		
		JButton bt_Update = new JButton("Update Selected");
		bt_Update.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				updatemode = true;
				bt_SaveNew.setEnabled(false);
				bt_AddNew.setEnabled(false);
				bt_Delete.setEnabled(false);
				bt_Save.setEnabled(true);
			}
		});
		bt_Update.setBounds(790, 42, 69, 17);
		contentPane_1.add(bt_Update);
		
		JButton bt_Save = new JButton("Save Selected");
		bt_Save.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				if(updatemode = true) {
					String id=table.getValueAt(table.getSelectedRow(), 0).toString();
					String f=tf_FirstName.getText();
					String l=tf_LastName.getText();
					String em=tf_Email.getText();
					String t=tf_Tel.getText();
					String a1=tf_Addr1.getText();
					String a2=tf_Addr2.getText();
					String c=tf_City.getText();
					String p=tf_Postcode.getText();
					String bt=tf_BusinessTel.getText();
					d.UpdateBusiness(id, f, l, em, t, a1, a2, c, p, bt);
					table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
				}
					else {
						String id=table.getValueAt(table.getSelectedRow(), 0).toString();
						String f=tf_FirstName.getText();
						String l=tf_LastName.getText();
						String em=tf_Email.getText();
						String t=tf_Tel.getText();
						String a1=tf_Addr1.getText();
						String a2=tf_Addr2.getText();
						String c=tf_City.getText();
						String p=tf_Postcode.getText();
						String bt=tf_BusinessTel.getText();
						
						table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
					}
			}
		});
		bt_Save.setBounds(790, 80, 69, 17);
		contentPane_1.add(bt_Save);
		
		JButton bt_Delete = new JButton("Delete Selected");
		bt_Delete.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				String id=table.getValueAt(table.getSelectedRow(), 0).toString();
				d.DeleteBusiness(id);
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
			}
		});
		bt_Delete.setBounds(790, 115, 69, 17);
		contentPane_1.add(bt_Delete);
		
		JScrollPane scrollPane_1 = new JScrollPane();
		scrollPane_1.setBounds(28, 150, 831, 452);
		contentPane_1.add(scrollPane_1);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {
				bt_Update.setEnabled(true);
				bt_Save.setEnabled(true);
				bt_Delete.setEnabled(true);
				bt_SaveNew.setEnabled(false);
				bt_AddNew.setEnabled(false);
				tf_FirstName.setText(table.getValueAt(table.getSelectedRow(),1).toString());
				tf_LastName.setText(table.getValueAt(table.getSelectedRow(),2).toString());
				tf_Email.setText(table.getValueAt(table.getSelectedRow(),3).toString());
				tf_Tel.setText(table.getValueAt(table.getSelectedRow(),4).toString());
				tf_Addr1.setText(table.getValueAt(table.getSelectedRow(),5).toString());
				tf_Addr2.setText(table.getValueAt(table.getSelectedRow(),6).toString());
				tf_City.setText(table.getValueAt(table.getSelectedRow(),7).toString());
				tf_Postcode.setText(table.getValueAt(table.getSelectedRow(),8).toString());
				tf_BusinessTel.setText(table.getValueAt(table.getSelectedRow(),9).toString());
			}
		});
		scrollPane_1.setViewportView(table);
	}

}
