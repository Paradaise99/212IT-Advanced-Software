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
}
