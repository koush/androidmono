package {0};

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;
import com.koushikdutta.utilities.AssetExtractor;

public class MonoActivity extends Activity
{{
    protected void onCreate(Bundle savedInstanceState)
    {{
        super.onCreate(savedInstanceState);
        Intent intent = getIntent();
        boolean debug = intent.getBooleanExtra("mono_debug", false);
        MonoBridge.initialize(debug);
        
        AssetExtractor.extractAssets(this, false);
        MonoBridge.loadAssembly("/data/data/com.koushikdutta.mono/android.dll");
        MonoBridge.loadAssembly(AssetExtractor.getAppRoot(this) + "/{0}.exe");

        Intent newIntent = new Intent(this, MainActivity.class);
        newIntent.putExtras(intent);
        startActivity(newIntent);
        finish();
    }}
}}
