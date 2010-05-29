package {0};

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class {1}{2}{3} implements MonoProxy
{{
	static
	{{
{4}
	}}

{5}

	long myGcHandle;
	@Override
	public long getGCHandle() {{
		return myGcHandle;
	}}

	@Override
	public void setGCHandle(long gcHandle) {{
		myGcHandle = gcHandle;
	}}
}}
