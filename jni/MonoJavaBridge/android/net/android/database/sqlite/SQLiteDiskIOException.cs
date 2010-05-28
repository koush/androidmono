namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteDiskIOException : android.database.sqlite.SQLiteException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteDiskIOException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteDiskIOException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteDiskIOException(@__env); 
			} 
		} 
		protected SQLiteDiskIOException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteDiskIOException2512; 
		public SQLiteDiskIOException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteDiskIOException.staticClass, global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException2512, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteDiskIOException2513; 
		public SQLiteDiskIOException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteDiskIOException.staticClass, global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException2513, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteDiskIOException.staticClass = @__class; 
			global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException2512 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDiskIOException.staticClass, "<init>", "()V"); 
			global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException2513 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDiskIOException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
