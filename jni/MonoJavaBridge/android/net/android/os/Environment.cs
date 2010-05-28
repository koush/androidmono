namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Environment : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Environment() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Environment), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Environment(@__env); 
			} 
		} 
		protected Environment(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRootDirectory5566; 
		public static global::java.io.File getRootDirectory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getRootDirectory5566)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataDirectory5567; 
		public static global::java.io.File getDataDirectory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getDataDirectory5567)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExternalStorageDirectory5568; 
		public static global::java.io.File getExternalStorageDirectory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageDirectory5568)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDownloadCacheDirectory5569; 
		public static global::java.io.File getDownloadCacheDirectory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getDownloadCacheDirectory5569)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExternalStorageState5570; 
		public static global::java.lang.String getExternalStorageState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Environment.staticClass, global::android.os.Environment._getExternalStorageState5570)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Environment5571; 
		public Environment()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Environment.staticClass, global::android.os.Environment._Environment5571, this); 
		} 
		public static global::java.lang.String MEDIA_REMOVED
		{ 
			get 
			{ 
				return "removed"; 
			} 
		} 
		public static global::java.lang.String MEDIA_UNMOUNTED
		{ 
			get 
			{ 
				return "unmounted"; 
			} 
		} 
		public static global::java.lang.String MEDIA_CHECKING
		{ 
			get 
			{ 
				return "checking"; 
			} 
		} 
		public static global::java.lang.String MEDIA_NOFS
		{ 
			get 
			{ 
				return "nofs"; 
			} 
		} 
		public static global::java.lang.String MEDIA_MOUNTED
		{ 
			get 
			{ 
				return "mounted"; 
			} 
		} 
		public static global::java.lang.String MEDIA_MOUNTED_READ_ONLY
		{ 
			get 
			{ 
				return "mounted_ro"; 
			} 
		} 
		public static global::java.lang.String MEDIA_SHARED
		{ 
			get 
			{ 
				return "shared"; 
			} 
		} 
		public static global::java.lang.String MEDIA_BAD_REMOVAL
		{ 
			get 
			{ 
				return "bad_removal"; 
			} 
		} 
		public static global::java.lang.String MEDIA_UNMOUNTABLE
		{ 
			get 
			{ 
				return "unmountable"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Environment.staticClass = @__class; 
			global::android.os.Environment._getRootDirectory5566 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getRootDirectory", "()Ljava/io/File;"); 
			global::android.os.Environment._getDataDirectory5567 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getDataDirectory", "()Ljava/io/File;"); 
			global::android.os.Environment._getExternalStorageDirectory5568 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getExternalStorageDirectory", "()Ljava/io/File;"); 
			global::android.os.Environment._getDownloadCacheDirectory5569 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getDownloadCacheDirectory", "()Ljava/io/File;"); 
			global::android.os.Environment._getExternalStorageState5570 = @__env.GetStaticMethodID(global::android.os.Environment.staticClass, "getExternalStorageState", "()Ljava/lang/String;"); 
			global::android.os.Environment._Environment5571 = @__env.GetMethodID(global::android.os.Environment.staticClass, "<init>", "()V"); 
		} 
	} 
} 
