package demoTestNg;

import static org.testng.Assert.assertFalse;

import org.testng.annotations.Test;

import list_function.FuntionTest;

public class demo_function_namnhuan {
	
	
	@Test
	public void testYear() {
		
		FuntionTest test = new FuntionTest();
		boolean ActualResult = test.namNhuan(100);
		boolean ExpectedReslut = false;
		
		assertFalse(ActualResult);
	}
}
