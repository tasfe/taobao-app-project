package com.sasapp.aqi;

import org.apache.cordova.DroidGap;
import org.apache.cordova.*;

import net.youmi.android.AdManager;
import net.youmi.android.AdView;
import android.graphics.Color;
import android.os.Bundle;
import android.view.Gravity;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import android.widget.LinearLayout.LayoutParams;



public class MainActivity extends DroidGap {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		
		//super.appView.setBackgroundColor(0);
		//super.appView.setBackgroundResource(R.drawable.loadingbg);
		
		super.onCreate(savedInstanceState); 
		
		super.setIntegerProperty("splashscreen", R.drawable.loadingbg);
		super.loadUrl("file:///android_asset/www/index.html");

		// Ӧ��Id Ӧ������ ���������(s) ����ģʽ
		AdManager.init(this,"537ef88653a2993c", "b9e10bcfe994a9fb", 30, false);
		
		LinearLayout layout=new LinearLayout(this); 
		layout.setOrientation(LinearLayout.VERTICAL); 
		//layout.setBackgroundResource(R.drawable.bg);	
				
		// ��ʼ�������������ʹ�������Ĺ��캯�������������͹��ı���ɫ��͸���ȼ�������ɫ
		 
		AdView adView = new AdView(this); 
		//LayoutParams params = new LayoutParams(LayoutParams.FILL_PARENT, LayoutParams.WRAP_CONTENT);		
		
		//LinearLayout gapLayout = super.root;  
		//gapLayout.addView(adView,params);  
	}

	public boolean onCreateOptionsMenu(Menu menu) { 
        menu.add(0,1,1,"�˳�"); 
        // TODO Auto-generated method stub 
        return super.onCreateOptionsMenu(menu); 
	}
	
	@Override 
    public boolean onOptionsItemSelected(MenuItem item) { 
            if(item.getItemId()==1){ 
                    finish(); 
            } 
            return super.onOptionsItemSelected(item); 
    } 

}

