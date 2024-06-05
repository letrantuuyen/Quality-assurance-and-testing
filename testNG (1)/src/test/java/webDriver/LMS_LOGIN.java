package webDriver;

import java.io.File;
import java.io.IOException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

import org.apache.commons.io.FileUtils;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.ITestResult;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;
import io.github.bonigarcia.wdm.WebDriverManager;

public class LMS_LOGIN {  
	WebDriver driver;
	@BeforeMethod
	public void setUp() {
		WebDriverManager.chromedriver().setup();
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://www.google.com/");
		driver.findElement(By.name("q")).sendKeys("LMS-IUH",Keys.ENTER);
		System.out.println(driver.getTitle());
		driver.get("https://lms.iuh.edu.vn/login/index.php");
	}
	
	//valid


	@Test(priority = 2, enabled = true)
	public void testLoginLMS1() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("20043331");
        passwordInput.sendKeys("1234");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/my/");
        
        
        String actualUrl = driver.getCurrentUrl(); 
        Assert.assertEquals(actualUrl, expectedResult);
	}
	
	//invalid
	
	@Test(priority = 1, enabled = true)
	public void testLoginLMS2() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("1234567");
        passwordInput.sendKeys("0409");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	@Test(priority = 3)
	public void testLoginLMS3() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys(" ");
        passwordInput.sendKeys("1234");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	
	@Test(priority = 4)
	public void testLoginLMS4() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("tuuyen");
        passwordInput.sendKeys("1234");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        // Kết quả mong đợi và kết quả thực tế
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	
	@Test(priority = 5, enabled = true)
	public void testLoginLMS5() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("20043331");
        passwordInput.sendKeys("123");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        // Kết quả mong đợi và kết quả thực tế
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	
	@Test(priority = 7, enabled = true)
	public void testLoginLMS6() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("20043331");
        passwordInput.sendKeys("");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	
	@Test(priority = 8, enabled = true)
	public void testLoginLMS7() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("2004333");
        passwordInput.sendKeys("1234");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        // Kết quả mong đợi và kết quả thực tế
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	
	@Test(priority = 6, enabled = true)
	public void testLoginLMS8() {
		WebElement usernameInput = driver.findElement(By.id("username"));
		WebElement passwordInput = driver.findElement(By.id("password"));
		WebElement loginButton = driver.findElement(By.id("loginbtn"));
		
		//nhập tên và password để kiểm tra 
		usernameInput.sendKeys("2004333311");
        passwordInput.sendKeys("1234");

        // Nhấp vào nút đăng nhập
        loginButton.click();
        
        String expectedResult = driver.getCurrentUrl();
        expectedResult.contains("https://lms.iuh.edu.vn/login/index.php");
        
        
        String actualUrl = driver.getCurrentUrl();  
        Assert.assertEquals(actualUrl, expectedResult);
	}
	

	@AfterMethod
    public void tearDown() {
        // Đóng trình duyệt sau khi hoàn thành mỗi phương thức kiểm thử
        driver.quit();
    }

}
