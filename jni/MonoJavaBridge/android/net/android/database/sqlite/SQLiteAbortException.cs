namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteAbortException : android.database.sqlite.SQLiteException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteAbortException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteAbortException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteAbortException(@__env); 
			} 
		} 
		protected SQLiteAbortException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteAbortException2434; 
		public SQLiteAbortException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteAbortException.staticClass, _SQLiteAbortException2434, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteAbortException2435; 
		public SQLiteAbortException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteAbortException.staticClass, _SQLiteAbortException2435, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteAbortException.staticClass = @__class; 
			global::android.database.sqlite.SQLiteAbortException._SQLiteAbortException2434 = @__env.GetMethodID(global::android.database.sqlite.SQLiteAbortException.staticClass, "<init>", "()V"); 
			global::android.database.sqlite.SQLiteAbortException._SQLiteAbortException2435 = @__env.GetMethodID(global::android.database.sqlite.SQLiteAbortException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
