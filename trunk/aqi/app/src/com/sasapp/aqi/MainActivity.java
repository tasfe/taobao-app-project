package com.sasapp.aqi;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import com.phonegap.*;

public class MainActivity extends DroidGap {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState); 
		super.setIntegerProperty("splashscreen", R.drawable.loadingbg);

		super.loadUrl("file:///android_asset/www/index.html",2);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_main, menu);
		return true;
	}

}
