namespace android.content.res 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class AssetManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AssetManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.AssetManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.AssetManager.AssetInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _close1848; 
			public sealed override void close() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					@__env.CallVoidMethod(this, _close1848); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _close1848); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _mark1849; 
			public sealed override void mark(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					@__env.CallVoidMethod(this, _mark1849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _mark1849, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reset1850; 
			public sealed override void reset() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					@__env.CallVoidMethod(this, _reset1850); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _reset1850); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read1851; 
			public sealed override int read() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallIntMethod(this, _read1851); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _read1851); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read1852; 
			public sealed override int read(byte[] arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallIntMethod(this, _read1852, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _read1852, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read1853; 
			public sealed override int read(byte[] arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallIntMethod(this, _read1853, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _read1853, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _skip1854; 
			public sealed override long skip(long arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallLongMethod(this, _skip1854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _skip1854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _available1855; 
			public sealed override int available() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallIntMethod(this, _available1855); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _available1855); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _markSupported1856; 
			public sealed override bool markSupported() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallBooleanMethod(this, _markSupported1856); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _markSupported1856); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getAssetInt1857; 
			public int getAssetInt() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetManager.AssetInputStream)) 
					return @__env.CallIntMethod(this, _getAssetInt1857); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetManager.AssetInputStream.staticClass, _getAssetInt1857); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.res.AssetManager.AssetInputStream.staticClass = @__class; 
				global::android.content.res.AssetManager.AssetInputStream._close1848 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "close", "()V"); 
				global::android.content.res.AssetManager.AssetInputStream._mark1849 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "mark", "(I)V"); 
				global::android.content.res.AssetManager.AssetInputStream._reset1850 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "reset", "()V"); 
				global::android.content.res.AssetManager.AssetInputStream._read1851 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "()I"); 
				global::android.content.res.AssetManager.AssetInputStream._read1852 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([B)I"); 
				global::android.content.res.AssetManager.AssetInputStream._read1853 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([BII)I"); 
				global::android.content.res.AssetManager.AssetInputStream._skip1854 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "skip", "(J)J"); 
				global::android.content.res.AssetManager.AssetInputStream._available1855 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "available", "()I"); 
				global::android.content.res.AssetManager.AssetInputStream._markSupported1856 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "markSupported", "()Z"); 
				global::android.content.res.AssetManager.AssetInputStream._getAssetInt1857 = @__env.GetMethodID(global::android.content.res.AssetManager.AssetInputStream.staticClass, "getAssetInt", "()I"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _list1858; 
		public java.lang.String[] list(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _list1858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _list1858, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close1859; 
		public void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				@__env.CallVoidMethod(this, _close1859); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetManager.staticClass, _close1859); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open1860; 
		public java.io.InputStream open(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _open1860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _open1860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open1861; 
		public java.io.InputStream open(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _open1861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _open1861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFd1862; 
		public android.content.res.AssetFileDescriptor openFd(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openFd1862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _openFd1862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openNonAssetFd1863; 
		public android.content.res.AssetFileDescriptor openNonAssetFd(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openNonAssetFd1863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _openNonAssetFd1863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openNonAssetFd1864; 
		public android.content.res.AssetFileDescriptor openNonAssetFd(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _openNonAssetFd1864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _openNonAssetFd1864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openXmlResourceParser1865; 
		public android.content.res.XmlResourceParser openXmlResourceParser(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, _openXmlResourceParser1865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _openXmlResourceParser1865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openXmlResourceParser1866; 
		public android.content.res.XmlResourceParser openXmlResourceParser(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, _openXmlResourceParser1866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _openXmlResourceParser1866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocales1867; 
		public java.lang.String[] getLocales() 
		{ 
			if (GetType() == typeof(android.content.res.AssetManager)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getLocales1867)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetManager.staticClass, _getLocales1867)); 
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
			global::android.content.res.AssetManager._list1858 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "list", "(Ljava/lang/String;)[Ljava/lang/String;"); 
			global::android.content.res.AssetManager._close1859 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "close", "()V"); 
			global::android.content.res.AssetManager._open1860 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;I)Ljava/io/InputStream;"); 
			global::android.content.res.AssetManager._open1861 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;)Ljava/io/InputStream;"); 
			global::android.content.res.AssetManager._openFd1862 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.res.AssetManager._openNonAssetFd1863 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.res.AssetManager._openNonAssetFd1864 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;"); 
			global::android.content.res.AssetManager._openXmlResourceParser1865 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.res.AssetManager._openXmlResourceParser1866 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.res.AssetManager._getLocales1867 = @__env.GetMethodID(global::android.content.res.AssetManager.staticClass, "getLocales", "()[Ljava/lang/String;"); 
		} 
	} 
} 
