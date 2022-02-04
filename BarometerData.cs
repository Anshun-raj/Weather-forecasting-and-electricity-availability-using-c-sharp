using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    class Program 
    {
        public static void Main() 
        {
           Forecast obj=new Forecast();
           Console.WriteLine("press 1.for weather forecasting");
           Console.WriteLine("press 2.for electricity availability");
           Console.WriteLine("Enter your choice:");
           string val1=Console.ReadLine();
           int val=Convert.ToInt32(val1);
           if(val==1)
           {
           	 obj.barometerData();
           }
           else if(val==2)
           {
           	 obj.electricData();
           }
           else
           {
           	 Console.WriteLine("Wrong Choice");
           }
           
        }
    }
    class Forecast
    {
    	public void barometerData()
    	{
    		float sum=0;
    		float avg;
    		Console.WriteLine("Enter the total no. of barometer readings:");
    		string dt=Console.ReadLine();
    		int n=Convert.ToInt32(dt);
    		float [] arr=new float[n];
    		for(int i=0;i<n;i++)
    		{
    			arr[i]=float.Parse(Console.ReadLine());
    			sum=sum+arr[i];
    		}
    		avg=sum/n;
    		if(avg<29.5)
    		{
    			Console.WriteLine("Weather is too stormy so its time to stay at home.");
    		}
    		else if(avg>=29.5 && avg<30.5)
    		{
    			Console.WriteLine("Rainfall will be occur in these days.");
    		}
    		else if(avg>=30.5)
    		{
    			Console.WriteLine("It's a sunny day so now it's a time for marketing.");
    		}
    	}
    	public void electricData()
    	{
            float sum=0;
    		float avg;
    		Console.WriteLine("Enter the total no. of barometer readings:");
    		string dt=Console.ReadLine();
    		int n=Convert.ToInt32(dt);
    		float [] arr=new float[n];
    		for(int i=0;i<n;i++)
    		{
    			arr[i]=float.Parse(Console.ReadLine());
    			sum=sum+arr[i];
    		}
    		avg=sum/n;
    		if(avg<29.5)
    		{
    			Console.WriteLine("Turn OFF the power cut button because weather is too stormy");
    		}
    		else if(avg>=29.5 && avg<30.5)
    		{
    			Console.WriteLine("Rainfall will be occur so turn OFF the power cut button");
    		}
    		else if(avg>=30.5)
    		{
    			Console.WriteLine("It's a sunny day so now it's time to turn ON the power cut button");
    		}
    	}
    }
 }
