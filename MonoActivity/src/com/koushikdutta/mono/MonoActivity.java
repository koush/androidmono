package com.koushikdutta.mono;

import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.lang.reflect.Method;
import java.util.Enumeration;
import java.util.Vector;
import java.util.zip.ZipEntry;
import java.util.zip.ZipFile;

import com.koushikdutta.utilities.AssetExtractor;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class MonoActivity extends Activity
{
	TextView mStatus;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState)
	{

		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		
		mStatus = (TextView) findViewById(R.id.StatusText);
		mStatus.setVerticalScrollBarEnabled(true);

		findViewById(R.id.LinearLayout).setVerticalScrollBarEnabled(true);
		
		AssetExtractor.extractAssets(this, true);
		mStatus.setText("All Files extracted!");
	}
}