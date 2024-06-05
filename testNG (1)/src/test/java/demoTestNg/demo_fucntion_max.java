package demoTestNg;

import static org.testng.Assert.assertEquals;
import static org.testng.Assert.assertFalse;

import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import list_function.FuntionTest;

public class demo_fucntion_max  {

	
	@Test
	public void testMax1() {
		FuntionTest test = new FuntionTest();
		int ActualResult = test.Max(10,9,8);
		int expectedResult = 10;
		assertEquals(ActualResult, expectedResult);
	}
	
	@Test
	public void testMax2() {
		FuntionTest test = new FuntionTest();
		int ActualResult = test.Max(10,9,11);
		int expectedResult = 11;
		assertEquals(ActualResult, expectedResult);
	}
	
	@Test
	public void testMax3() {
		FuntionTest test = new FuntionTest();
		int ActualResult = test.Max(9,10,8);
		int expectedResult = 10;
		assertEquals(ActualResult, expectedResult);
	}
	
	@Test
	public void testMax4() {
		FuntionTest test = new FuntionTest();
		int ActualResult = test.Max(9,8,10);
		int expectedResult = 10;
		assertEquals(ActualResult, expectedResult);
	}
	
	
//	
//	@Test(dataProvider = "data-provider",dataProviderClass = FuntionTest.class)
//	public void tong(int num1, int num2, int expected) {
//		
//		FuntionTest test = new FuntionTest();
//		int ActualResult = test.tong(num1, num2);
//        assert ActualResult == expected;
//	}
	
//	
//	@Test(dataProvider = "data-provider",dataProviderClass = FuntionTest.class)
//	  public void Max(int num1, int num2, int num3, int expected) {
//		FuntionTest test = new FuntionTest();
//		int ActualResult = test.Max(num1, num2, num3);
//        assert ActualResult == expected;
//    }
}
