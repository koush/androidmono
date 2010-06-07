package com.koushikdutta.twitter;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;
import com.koushikdutta.utilities.AssetExtractor;

public class MonoActivity extends Activity
{
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        Intent intent = getIntent();
        String debuggerAgentOptions = intent.getStringExtra("mono_debugger_agent_options");
        MonoBridge.initialize(getFilesDir().getAbsolutePath(), debuggerAgentOptions);
        
        AssetExtractor.extractAssets(this, false);
        MonoBridge.loadAssembly("/data/data/com.koushikdutta.mono/android.dll");
        MonoBridge.loadAssembly(AssetExtractor.getAppRoot(this) + "/com.koushikdutta.twitter.exe");

        Intent newIntent = new Intent(this, MainActivity.class);
        newIntent.putExtras(intent);
        startActivity(newIntent);
        finish();
    }
}
