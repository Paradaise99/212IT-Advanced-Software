import java.sql.DriverManager;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.ResultSet;
import java.sql.*;

public class dbConn {
	String connString = "jdbc:mysql://db212it.cgqw6genwnm1.us-east-1.rds.amazonaws.com/HarrisContactDb";
	String username = "admin";
	String password = "Paradaise99?";
	Connection con = null;
	
	public dbConn() {
		try {
			con = DriverManager.getConnection(connString,username,password);
			System.out.println("Connected");
	  
		} catch (SQLException e) {
			e.printStackTrace();
			System.out.println("Not Connected");
		}
	}
	
	public ResultSet GetAllPersonal() {
		ResultSet rs=null;
		String sql="{CALL selectAllPersonal()}";
		try {
		java.sql.CallableStatement cst= con.prepareCall(sql);
		rs=cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return rs;
		
	}
	public void UpdatePerosnal(String id, String f, String l, String em, String t, String a1, String a2, String c, String p, String ht) {
		ResultSet rs=null;
		String sql="{CALL updatePersonal(?,?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			cst.setString(1, id);
			cst.setString(2, f);
			cst.setString(3, l);
			cst.setString(4, em);
			cst.setString(5, t);
			cst.setString(6, a1);
			cst.setString(7, a2);
			cst.setString(8, c);
			cst.setString(9, p);
			cst.setString(10, ht);
			rs=cst.executeQuery();
			} catch (SQLException e) {
				e.printStackTrace();
			}
			
	}
	public void InsertPersonal(String f, String l, String em, String t, String a1, String a2, String c, String p, String ht) {
		String sql="{CALL insertPersonal(?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			cst.setString(1, f);
			cst.setString(2, l);
			cst.setString(3, em);
			cst.setString(4, t);
			cst.setString(5, a1);
			cst.setString(6, a2);
			cst.setString(7, c);
			cst.setString(8, p);
			cst.setString(9, ht);
			cst.executeQuery();
		} catch (SQLException e){
			e.printStackTrace();
		}
		
		
	}
	public void DeletePersonal(String id) {
		String sql="{CALL deletePersonal(?)}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			cst.setString(1, id);
			cst.executeQuery();
		} catch (SQLException e){
			e.printStackTrace();
		}
	}
	
	
	public ResultSet GetAllBusiness() {
		ResultSet rs=null;
		String sql="{CALL selectAllBusiness()}";
		try {
		java.sql.CallableStatement cst= con.prepareCall(sql);
		rs=cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return rs;
		
	}
	
	public void UpdateBusiness(String id, String f, String l, String em, String t, String a1, String a2, String c, String p, String bt) {
		ResultSet rs=null;
		String sql="{CALL updateBusiness(?,?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			cst.setString(1, id);
			cst.setString(2, f);
			cst.setString(3, l);
			cst.setString(4, em);
			cst.setString(5, t);
			cst.setString(6, a1);
			cst.setString(7, a2);
			cst.setString(8, c);
			cst.setString(9, p);
			cst.setString(10, bt);
			rs=cst.executeQuery();
			} catch (SQLException e) {
				e.printStackTrace();
			}
			
	}
	
	public void InsertBusiness(String f, String l, String em, String t, String a1, String a2, String c, String p, String bt) {
		String sql="{CALL insertBusiness(?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			cst.setString(1, f);
			cst.setString(2, l);
			cst.setString(3, em);
			cst.setString(4, t);
			cst.setString(5, a1);
			cst.setString(6, a2);
			cst.setString(7, c);
			cst.setString(8, p);
			cst.setString(9, bt);
			cst.executeQuery();
		} catch (SQLException e){
			e.printStackTrace();
		}
		
		
	}
	
	public void DeleteBusiness(String id) {
		String sql="{CALL deleteBusiness(?)}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			cst.setString(1, id);
			cst.executeQuery();
		} catch (SQLException e){
			e.printStackTrace();
		}
	}
	
}
