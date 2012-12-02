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
		 
		 
	        // 创建WebView
	        final WebView webView= new WebView(this);
	        
	        // 获取WebView配置
	        WebSettings ws = webView.getSettings();
	        // 启用JavaScript
	        ws.setJavaScriptEnabled(true);
	       webView.setScrollBarStyle(View.SCROLLBARS_INSIDE_OVERLAY);  
	        //载入assets目录下的一个页面
	        webView.loadUrl("file:///android_asset/www/index.html");
	        
	     // 应用Id 应用密码 广告请求间隔(s) 测试模式
			AdManager.init(this,"62a33f1813ee055b", "277a03a18d99ba6b", 30, false);
			
			final LinearLayout layout=new LinearLayout(this); 
			layout.setOrientation(LinearLayout.VERTICAL); 
							
			// 初始化广告条，可以使用其他的构造函数设置文字类型广告的背景色、透明度及字体颜色
			AdView adView = new AdView(this); 
			LayoutParams params = new LayoutParams(LayoutParams.FILL_PARENT, LayoutParams.WRAP_CONTENT);		
			LayoutParams paramsWebView = new LayoutParams(LayoutParams.FILL_PARENT, LayoutParams.MATCH_PARENT);		

			layout.addView(webView,paramsWebView);
			 
					
					// 初始化广告视图 AdView adView = new AdView(this);
					FrameLayout.LayoutParams paramsAd = new
					FrameLayout.LayoutParams(FrameLayout.LayoutParams.FILL_PARENT,
					FrameLayout.LayoutParams.WRAP_CONTENT);
					// 设置广告出现的位置 ( 悬浮于屏幕右下角 )
					params.gravity=Gravity.BOTTOM|Gravity.RIGHT;
					// 将广告视图加入 Activity 中 addContentView(adView, params);
					layout.addView(adView,paramsAd);
					
	        webView.setWebViewClient(new WebViewClient(){  
	        	  
	            @Override  
	            public void onPageFinished(WebView view, String url) {  
	            	 // 切换到内容视图
	    	        //setContentView(webView);  
	    	        setContentView(layout); 
	                super.onPageFinished(view, url);  
	            }  
	              
	        }); 
	        
	      //JavaScript中可以通过"window.js2java"来调用Java对象的方法
	        webView.addJavascriptInterface(new JSInvokeClass(), "js2java");
	        
		
	     // 初始化积分墙，请务必在主Activity中调用该方法进行初始化
	     			YoumiOffersManager.init(MainActivity.this, "62a33f1813ee055b", "277a03a18d99ba6b");
	     			// 调用打开积分墙接口，第二个参数指定推荐应用列表模式
	}
	
	/**网页Javascript调用接口**/
	class JSInvokeClass {
	    public void back() {
	    	
			YoumiOffersManager.showOffers(MainActivity.this,
					YoumiOffersManager.TYPE_REWARDLESS_APPLIST);

			//startActivity(intent);
	    }
	}
	
	public boolean onCreateOptionsMenu(Menu menu) { 
        menu.add(0,1,1,"退出"); 
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

