package list_function;

import org.testng.annotations.Test;

import java.lang.reflect.Method;

import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;


public class FuntionTest {


	public int tong(int a, int b) {
		return (a+b);
	}
	
	public boolean namNhuan(int year) {
		 
		if(year > 10000 || year < 1000)
			return false;
		else if (year % 100 == 0)
			 if(year % 400 == 0)
				return true;
			else
				return false;
			else if ( year%4 == 0)
				return true;
			else
				return false;
	}
	
	
	@Test(dataProvider = "data-provider")
	public int Max(int A, int B, int C) {
		int Maximum;
		if (A > B)
			if (A > C)
				Maximum = A;
			else
				Maximum = C;
		else if (B > C)
			Maximum = B;
		else
			Maximum = C;
		return Maximum;
	}
	
	public static String giaiPhuongTrinhBac2(double a, double b, double c) {
	    double delta = b * b - 4 * a * c;
	    String result;

	    if (delta > 0) {
	        double x1 = (-b + Math.sqrt(delta)) / (2 * a);
	        double x2 = (-b - Math.sqrt(delta)) / (2 * a);
	        result = "Phương trình có hai nghiệm!";
	    } else if (delta == 0) {
	        double x = -b / (2 * a);
	        result = "Phương trình có một nghiệm kép:";
	    } else {
	        result = "Phương trình vô nghiệm";
	    }
	    
	    return result;
	}

	
	@DataProvider(name = "data-provider")
	public Object[][] testProvider(Method method) {
		
		Object[][] data = null;
		if(method.getName().equals("MaxAndMean")) {
			 data =  new Object[][] {
	            { 2, 3, 5, 5 },
	            { 4, 6, 3, 6 },
	            { 9, 6, 2, 9 }
	        };
		}
	        else if(method.getName().equals("tong")){
	        	 data =  new  Object[][] {
	                { 2, 3, 5},
	                { 4, 6, 10},
	                { 9, 6, 15}
	            };
	        }
		return data;
	}
	
	@DataProvider(name = "TestData")
    public Object[][] testData() {
		
        return new Object[][] {
            { 2, 3, 5, 5 },
            { 4, 6, 3, 6 },
            { 9, 6, 2, 9 }
        };
    }

}

