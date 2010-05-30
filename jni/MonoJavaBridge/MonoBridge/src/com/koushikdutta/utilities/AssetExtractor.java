package com.koushikdutta.utilities;

import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.Enumeration;
import java.util.Vector;
import java.util.zip.ZipEntry;
import java.util.zip.ZipFile;

import android.content.ContextWrapper;
import android.util.Log;

public class AssetExtractor {
	final static String ZIP_FILTER = "assets";
	final static int BUFSIZE = 100000;
	final static String LOGTAG = "AssetExtractor";

	static void Log(String string)
	{
		Log.v(LOGTAG, string);
	}
	
	static void copyStreams(InputStream is, FileOutputStream fos)
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
				os.close();
				is.close();
			}
			catch (IOException e2)
			{
				Log("Exception while closing the stream: " + e2);
			}
		}
	}
	
	public static String getAppRoot(ContextWrapper context) 
	{
		 return "/data/data/" + context.getPackageName();
	}

	public static void extractAssets(ContextWrapper context, boolean worldReadable)
	{
		try
		{
			Runtime runtime = Runtime.getRuntime();
			String appRoot = getAppRoot(context);
			File zipFile = new File(context.getPackageCodePath());
			long zipLastModified = zipFile.lastModified();
			ZipFile zip = new ZipFile(context.getPackageCodePath());
			Vector<ZipEntry> files = pluginsFilesFromZip(zip);
			int zipFilterLength = ZIP_FILTER.length();

			Enumeration entries = files.elements();
			while (entries.hasMoreElements())
			{
				ZipEntry entry = (ZipEntry) entries.nextElement();
				String path = entry.getName().substring(zipFilterLength);
				File outputFile = new File(appRoot, path);
				outputFile.getParentFile().mkdirs();

				if (outputFile.exists() && entry.getSize() == outputFile.length() && zipLastModified < outputFile.lastModified())
				{
					Log(outputFile.getName() + " already extracted.");
				}
				else
				{
					FileOutputStream fos = new FileOutputStream(outputFile);
					Log("Copied " + entry + " to " + appRoot + "/" + path);
					copyStreams(zip.getInputStream(entry), fos);
					String curPath = outputFile.getAbsolutePath();
					if (worldReadable)
					{
						do
						{
							runtime.exec("chmod 755 " + curPath);
							curPath = new File(curPath).getParent();
						}
						while (!curPath.equals(appRoot));
					}
				}
			}
		}
		catch (IOException e)
		{
			Log("Error: " + e.getMessage());
		}
	}
	
	public static Vector<ZipEntry> pluginsFilesFromZip(ZipFile zip)
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
