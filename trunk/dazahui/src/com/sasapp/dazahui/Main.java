package com.sasapp.dazahui;
import android.os.Bundle;
import com.phonegap.*;

public class Main extends DroidGap {
	
	@Override
	public void onCreate(Bundle bundle)
	{
		super.onCreate(bundle); 
		super.loadUrl("file:///android_asset/www/index.html");
	}
}
