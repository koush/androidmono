namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AssetManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AssetManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AssetInputStream : java.io.InputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AssetInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _close4092;
			public sealed override void close()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "close", "()V", ref global::android.content.res.AssetManager.AssetInputStream._close4092);
			}
			internal static global::MonoJavaBridge.MethodId _mark4093;
			public sealed override void mark(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "mark", "(I)V", ref global::android.content.res.AssetManager.AssetInputStream._mark4093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _reset4094;
			public sealed override void reset()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "reset", "()V", ref global::android.content.res.AssetManager.AssetInputStream._reset4094);
			}
			internal static global::MonoJavaBridge.MethodId _read4095;
			public sealed override int read()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "()I", ref global::android.content.res.AssetManager.AssetInputStream._read4095);
			}
			internal static global::MonoJavaBridge.MethodId _read4096;
			public sealed override int read(byte[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([B)I", ref global::android.content.res.AssetManager.AssetInputStream._read4096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read4097;
			public sealed override int read(byte[] arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([BII)I", ref global::android.content.res.AssetManager.AssetInputStream._read4097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _skip4098;
			public sealed override long skip(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "skip", "(J)J", ref global::android.content.res.AssetManager.AssetInputStream._skip4098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _available4099;
			public sealed override int available()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "available", "()I", ref global::android.content.res.AssetManager.AssetInputStream._available4099);
			}
			internal static global::MonoJavaBridge.MethodId _markSupported4100;
			public sealed override bool markSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "markSupported", "()Z", ref global::android.content.res.AssetManager.AssetInputStream._markSupported4100);
			}
			public new int AssetInt
			{
				get
				{
					return getAssetInt();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getAssetInt4101;
			public int getAssetInt()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "getAssetInt", "()I", ref global::android.content.res.AssetManager.AssetInputStream._getAssetInt4101);
			}
			static AssetInputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetManager.AssetInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetManager$AssetInputStream"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _list4102;
		public global::java.lang.String[] list(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.res.AssetManager.staticClass, "list", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::android.content.res.AssetManager._list4102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _close4103;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.staticClass, "close", "()V", ref global::android.content.res.AssetManager._close4103);
		}
		internal static global::MonoJavaBridge.MethodId _open4104;
		public global::java.io.InputStream open(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;I)Ljava/io/InputStream;", ref global::android.content.res.AssetManager._open4104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _open4105;
		public global::java.io.InputStream open(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::android.content.res.AssetManager._open4105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFd4106;
		public global::android.content.res.AssetFileDescriptor openFd(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.AssetManager._openFd4106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openNonAssetFd4107;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.AssetManager._openNonAssetFd4107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openNonAssetFd4108;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.AssetManager._openNonAssetFd4108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openXmlResourceParser4109;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.AssetManager._openXmlResourceParser4109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _openXmlResourceParser4110;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.AssetManager._openXmlResourceParser4110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		public new global::java.lang.String[] Locales
		{
			get
			{
				return getLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocales4111;
		public global::java.lang.String[] getLocales()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.res.AssetManager.staticClass, "getLocales", "()[Ljava/lang/String;", ref global::android.content.res.AssetManager._getLocales4111) as java.lang.String[];
		}
		public static int ACCESS_UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int ACCESS_RANDOM
		{
			get
			{
				return 1;
			}
		}
		public static int ACCESS_STREAMING
		{
			get
			{
				return 2;
			}
		}
		public static int ACCESS_BUFFER
		{
			get
			{
				return 3;
			}
		}
		static AssetManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.AssetManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
