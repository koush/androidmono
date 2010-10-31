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
			private static global::MonoJavaBridge.MethodId _m0;
			public sealed override void close()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "close", "()V", ref global::android.content.res.AssetManager.AssetInputStream._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public sealed override void mark(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "mark", "(I)V", ref global::android.content.res.AssetManager.AssetInputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public sealed override void reset()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "reset", "()V", ref global::android.content.res.AssetManager.AssetInputStream._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public sealed override int read()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "()I", ref global::android.content.res.AssetManager.AssetInputStream._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public sealed override int read(byte[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([B)I", ref global::android.content.res.AssetManager.AssetInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public sealed override int read(byte[] arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([BII)I", ref global::android.content.res.AssetManager.AssetInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public sealed override long skip(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "skip", "(J)J", ref global::android.content.res.AssetManager.AssetInputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public sealed override int available()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "available", "()I", ref global::android.content.res.AssetManager.AssetInputStream._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public sealed override bool markSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "markSupported", "()Z", ref global::android.content.res.AssetManager.AssetInputStream._m8);
			}
			public new int AssetInt
			{
				get
				{
					return getAssetInt();
				}
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public int getAssetInt()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, "getAssetInt", "()I", ref global::android.content.res.AssetManager.AssetInputStream._m9);
			}
			static AssetInputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetManager.AssetInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetManager$AssetInputStream"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.String[] list(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.res.AssetManager.staticClass, "list", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::android.content.res.AssetManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetManager.staticClass, "close", "()V", ref global::android.content.res.AssetManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.io.InputStream open(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;I)Ljava/io/InputStream;", ref global::android.content.res.AssetManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.io.InputStream open(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::android.content.res.AssetManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::android.content.res.AssetFileDescriptor openFd(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.AssetManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.AssetFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.AssetManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.AssetFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.AssetManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.AssetFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.AssetManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.XmlResourceParser;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.AssetManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		public new global::java.lang.String[] Locales
		{
			get
			{
				return getLocales();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.String[] getLocales()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.res.AssetManager.staticClass, "getLocales", "()[Ljava/lang/String;", ref global::android.content.res.AssetManager._m9) as java.lang.String[];
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
	}
}
