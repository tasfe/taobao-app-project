package com.sasapp.aqi;


import net.youmi.android.AdManager;
import net.youmi.android.AdView;
import net.youmi.android.appoffers.YoumiOffersManager;
import android.app.Activity;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.os.Handler;
import android.view.Gravity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import android.widget.LinearLayout.LayoutParams;
import android.widget.Toast;



public class MainActivity extends Activity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		
		//super.appView.setBackgroundColor(0);
		//super.appView.setBackgroundResource(R.drawable.loadingbg);
		
		//super.onCreate(savedInstanceState); 
		
		//super.setIntegerProperty("splashscreen", R.drawable.loadingbg);
		//super.loadUrl("file:///android_asset/www/index.html");

		 super.onCreate(savedInstanceState);
		 setContentView(R.layout.activity_main);
		 
		 
	        // ����WebView
	        final WebView webView= new WebView(this);
	        
	        // ��ȡWebView����
	        WebSettings ws = webView.getSettings();
	        // ����JavaScript
	        ws.setJavaScriptEnabled(true);
	       webView.setScrollBarStyle(View.SCROLLBARS_INSIDE_OVERLAY);  
	        //����assetsĿ¼�µ�һ��ҳ��
	        webView.loadUrl("file:///android_asset/www/index.html");
	        
	     // Ӧ��Id Ӧ������ ���������(s) ����ģʽ
			AdManager.init(this,"62a33f1813ee055b", "277a03a18d99ba6b", 30, false);
			
			final LinearLayout layout=new LinearLayout(this); 
			layout.setOrientation(LinearLayout.VERTICAL); 
							
			// ��ʼ�������������ʹ�������Ĺ��캯�������������͹��ı���ɫ��͸���ȼ�������ɫ
			AdView adView = new AdView(this); 
			LayoutParams params = new LayoutParams(LayoutParams.FILL_PARENT, LayoutParams.WRAP_CONTENT);		
			LayoutParams paramsWebView = new LayoutParams(LayoutParams.FILL_PARENT, LayoutParams.MATCH_PARENT);		

			layout.addView(webView,paramsWebView);
			 
					
					// ��ʼ�������ͼ AdView adView = new AdView(this);
					FrameLayout.LayoutParams paramsAd = new
					FrameLayout.LayoutParams(FrameLayout.LayoutParams.FILL_PARENT,
					FrameLayout.LayoutParams.WRAP_CONTENT);
					// ���ù����ֵ�λ�� ( ��������Ļ���½� )
					params.gravity=Gravity.BOTTOM|Gravity.RIGHT;
					// �������ͼ���� Activity �� addContentView(adView, params);
					layout.addView(adView,paramsAd);
					
	        webView.setWebViewClient(new WebViewClient(){  
	        	  
	            @Override  
	            public void onPageFinished(WebView view, String url) {  
	            	 // �л���������ͼ
	    	        //setContentView(webView);  
	    	        setContentView(layout); 
	                super.onPageFinished(view, url);  
	            }  
	              
	        }); 
	        
	      //JavaScript�п���ͨ��"window.js2java"������Java����ķ���
	        webView.addJavascriptInterface(new JSInvokeClass(), "js2java");
	        
		
	     // ��ʼ������ǽ�����������Activity�е��ø÷������г�ʼ��
	     			YoumiOffersManager.init(MainActivity.this, "62a33f1813ee055b", "277a03a18d99ba6b");
	     			// ���ô򿪻���ǽ�ӿڣ��ڶ�������ָ���Ƽ�Ӧ���б�ģʽ
	}
	
	/**��ҳJavascript���ýӿ�**/
	class JSInvokeClass {
	    public void back() {
	    	
			YoumiOffersManager.showOffers(MainActivity.this,
					YoumiOffersManager.TYPE_REWARDLESS_APPLIST);

			//startActivity(intent);
	    }
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

