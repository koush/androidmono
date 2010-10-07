namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class AssetManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AssetManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.AssetManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.res.AssetManager(@__env);
			}
		}
		internal AssetManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class AssetInputStream : java.io.InputStream
		{
			internal static global::java.lang.Class staticClass;
			static AssetInputStream()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.AssetManager.AssetInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.res.AssetManager.AssetInputStream(@__env);
				}
			}
			internal AssetInputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _close2071;
			public sealed override void close() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream._close2071);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._close2071);
			}
			internal static global::net.sf.jni4net.jni.MethodId _mark2072;
			public sealed override void mark(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream._mark2072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._mark2072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _reset2073;
			public sealed override void reset() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream._reset2073);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._reset2073);
			}
			internal static global::net.sf.jni4net.jni.MethodId _read2074;
			public sealed override int read() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream._read2074);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._read2074);
			}
			internal static global::net.sf.jni4net.jni.MethodId _read2075;
			public sealed override int read(byte[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream._read2075, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._read2075, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _read2076;
			public sealed override int read(byte[] arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream._read2076, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._read2076, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _skip2077;
			public sealed override long skip(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.content.res.AssetManager.AssetInputStream._skip2077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._skip2077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _available2078;
			public sealed override int available() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream._available2078);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._available2078);
			}
			internal static global::net.sf.jni4net.jni.MethodId _markSupported2079;
			public sealed override bool markSupported() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.content.res.AssetManager.AssetInputStream._markSupported2079);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._markSupported2079);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getAssetInt2080;
			public int getAssetInt() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetManager.AssetInputStream._getAssetInt2080);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._getAssetInt2080);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.AssetManager.AssetInputStream.staticClass = @__class;
				global::android.content.res.AssetManager.AssetInputStream._close2071 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "close", "()V");
				global::android.content.res.AssetManager.AssetInputStream._mark2072 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "mark", "(I)V");
				global::android.content.res.AssetManager.AssetInputStream._reset2073 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "reset", "()V");
				global::android.content.res.AssetManager.AssetInputStream._read2074 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "()I");
				global::android.content.res.AssetManager.AssetInputStream._read2075 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([B)I");
				global::android.content.res.AssetManager.AssetInputStream._read2076 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([BII)I");
				global::android.content.res.AssetManager.AssetInputStream._skip2077 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "skip", "(J)J");
				global::android.content.res.AssetManager.AssetInputStream._available2078 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "available", "()I");
				global::android.content.res.AssetManager.AssetInputStream._markSupported2079 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "markSupported", "()Z");
				global::android.content.res.AssetManager.AssetInputStream._getAssetInt2080 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "getAssetInt", "()I");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _list2081;
		public global::java.lang.String[] list(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._list2081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._list2081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2082;
		public void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.AssetManager._close2082);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._close2082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _open2083;
		public global::java.io.InputStream open(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._open2083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._open2083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _open2084;
		public global::java.io.InputStream open(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._open2084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._open2084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFd2085;
		public global::android.content.res.AssetFileDescriptor openFd(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._openFd2085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openFd2085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openNonAssetFd2086;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._openNonAssetFd2086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openNonAssetFd2086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openNonAssetFd2087;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._openNonAssetFd2087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openNonAssetFd2087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openXmlResourceParser2088;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._openXmlResourceParser2088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openXmlResourceParser2088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openXmlResourceParser2089;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._openXmlResourceParser2089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openXmlResourceParser2089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocales2090;
		public global::java.lang.String[] getLocales() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetManager._getLocales2090));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._getLocales2090));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.AssetManager.staticClass = @__class;
			global::android.content.res.AssetManager._list2081 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "list", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.res.AssetManager._close2082 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "close", "()V");
			global::android.content.res.AssetManager._open2083 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;I)Ljava/io/InputStream;");
			global::android.content.res.AssetManager._open2084 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::android.content.res.AssetManager._openFd2085 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.AssetManager._openNonAssetFd2086 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.AssetManager._openNonAssetFd2087 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.AssetManager._openXmlResourceParser2088 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.AssetManager._openXmlResourceParser2089 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.AssetManager._getLocales2090 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "getLocales", "()[Ljava/lang/String;");
		}
	}
}
