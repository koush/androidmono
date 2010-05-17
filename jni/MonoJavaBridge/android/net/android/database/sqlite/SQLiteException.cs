namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteException : android.database.SQLException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteException(@__env); 
			} 
		} 
		protected SQLiteException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteException2326; 
		public SQLiteException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteException.staticClass, _SQLiteException2326, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteException2327; 
		public SQLiteException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteException.staticClass, _SQLiteException2327, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteException.staticClass = @__class; 
			global::android.database.sqlite.SQLiteException._SQLiteException2326 = @__env.GetMethodID(global::android.database.sqlite.SQLiteException.staticClass, "<init>", "()V"); 
			global::android.database.sqlite.SQLiteException._SQLiteException2327 = @__env.GetMethodID(global::android.database.sqlite.SQLiteException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
