package com.koushikdutta.mono;

import android.app.Activity;
import android.app.Application;
import android.graphics.Paint.FontMetrics;
import android.os.Bundle;
import android.widget.TextView;

import com.koushikdutta.utilities.AssetExtractor;

public class MonoActivity extends Activity {
	TextView mStatus;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {

		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		mStatus = (TextView) findViewById(R.id.StatusText);
		mStatus.setVerticalScrollBarEnabled(true);

		findViewById(R.id.LinearLayout).setVerticalScrollBarEnabled(true);
		
		AssetExtractor.extractAssets(this, true);
		mStatus.setText("All Files extracted!");
	}
}
