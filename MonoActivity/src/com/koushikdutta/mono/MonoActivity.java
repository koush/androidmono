package com.koushikdutta.mono;

import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.Enumeration;
import java.util.Vector;
import java.util.zip.ZipEntry;
import java.util.zip.ZipFile;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

public class MonoActivity extends Activity
{
	static Runtime mRuntime = Runtime.getRuntime();
	final static String mAppRoot = "/data/data/com.koushikdutta.mono";
	final static int BUFSIZE = 10000;
	final static String APK_PATH = "/data/app/com.koushikdutta.mono.apk";
	final static String ZIP_FILTER = "assets";
	TextView mStatus;

	final static String LOGTAG = "MonoActivity";
	
	public void Log(String string)
	{
		Log.v(LOGTAG, string);
		mStatus.setText(mStatus.getText() + "\n" + string);
	}

	public void copyStreams(InputStream is, FileOutputStream fos)
	{
		BufferedOutputStream os = null;
		try
		{
			byte data[] = new byte[BUFSIZE];
			int count;
			os = new BufferedOutputStream(fos, BUFSIZE);
			while ((count = is.read(data, 0, BUFSIZE)) != -1)
			{
				os.write(data, 0, count);
			}
			os.flush();
		}
		catch (IOException e)
		{
			Log("Exception while copying: " + e);
		}
		finally
		{
			try
			{
				if (os != null)
				{
					os.close();
				}
			}
			catch (IOException e2)
			{
				Log("Exception while closing the stream: " + e2);
			}
		}
	}

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		
		mStatus = (TextView) findViewById(R.id.StatusText);
		mStatus.setVerticalScrollBarEnabled(true);

		findViewById(R.id.LinearLayout).setVerticalScrollBarEnabled(true);

//		try
//		{
//			// clean up the pre-Bionic installations
//			File dir = new File(mRoot, "lib");
//			File[] files = dir.listFiles();
//			for (int i = 0; i < files.length; i++)
//			{
//				try
//				{
//					File file = files[i];
//					if (!file.isDirectory())
//						file.delete();
//				}
//				catch (Exception ex)
//				{
//				}
//			}
//		}
//		catch (Exception ex)
//		{
//		}
//		
//		
		try
		{
			File zipFile = new File(APK_PATH);
			long zipLastModified = zipFile.lastModified();
			ZipFile zip = new ZipFile(APK_PATH);
			Vector<ZipEntry> files = pluginsFilesFromZip(zip);
			int zipFilterLength = ZIP_FILTER.length();

			Enumeration entries = files.elements();
			while (entries.hasMoreElements())
			{
				ZipEntry entry = (ZipEntry) entries.nextElement();
				String path = entry.getName().substring(zipFilterLength);
				File outputFile = new File(mAppRoot, path);
				outputFile.getParentFile().mkdirs();

				if (outputFile.exists() && entry.getSize() == outputFile.length() && zipLastModified < outputFile.lastModified())
				{
					Log(outputFile.getName() + " already extracted.");
				}
				else
				{
					FileOutputStream fos = new FileOutputStream(outputFile);
					Log("Copied " + entry + " to " + mAppRoot + "/" + path);
					copyStreams(zip.getInputStream(entry), fos);
					String curPath = outputFile.getAbsolutePath();
					do
					{
						mRuntime.exec("/system/bin/chmod 755 " + curPath);
						curPath = new File(curPath).getParent();
					}
					while (!curPath.equals(mAppRoot));
				}
			}
		}
		catch (IOException e)
		{
			Log("Error: " + e.getMessage());
		}
	}

	public Vector<ZipEntry> pluginsFilesFromZip(ZipFile zip)
	{
		Vector<ZipEntry> list = new Vector<ZipEntry>();
		Enumeration entries = zip.entries();
		while (entries.hasMoreElements())
		{
			ZipEntry entry = (ZipEntry) entries.nextElement();
			if (entry.getName().startsWith(ZIP_FILTER))
			{
				list.add(entry);
			}
		}
		return list;
	}
}