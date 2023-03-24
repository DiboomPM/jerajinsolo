package org.zerock.persistence;

import java.sql.Connection;
import java.sql.DriverManager;

import org.junit.Test;

import lombok.extern.log4j.Log4j;

@Log4j
public class JDBCTests {

	@Test
	public void testConnection() {
		
		Connection conn =  null;
		
		try {
			Class.forName("oracle.jdbc.driver.OracleDriver");
			log.info("드라이버 확인");
			
			conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521/orcl", "java", "oracle");
			log.info("연결 성공");
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if(conn !=null) conn.close();
			} catch (Exception e) {
				e.printStackTrace();
			}
		}
	}
}
