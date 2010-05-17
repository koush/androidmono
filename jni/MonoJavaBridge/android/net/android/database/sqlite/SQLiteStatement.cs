namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SQLiteStatement : android.database.sqlite.SQLiteProgram
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SQLiteStatement() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteStatement), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.SQLiteStatement(@__env); 
			} 
		} 
		protected SQLiteStatement(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _execute2378; 
		public virtual void execute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteStatement)) 
				@__env.CallVoidMethod(this, _execute2378); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteStatement.staticClass, _execute2378); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _executeInsert2379; 
		public virtual long executeInsert() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteStatement)) 
				return @__env.CallLongMethod(this, _executeInsert2379); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteStatement.staticClass, _executeInsert2379); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _simpleQueryForLong2380; 
		public virtual long simpleQueryForLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteStatement)) 
				return @__env.CallLongMethod(this, _simpleQueryForLong2380); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.sqlite.SQLiteStatement.staticClass, _simpleQueryForLong2380); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _simpleQueryForString2381; 
		public virtual java.lang.String simpleQueryForString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteStatement)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _simpleQueryForString2381)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteStatement.staticClass, _simpleQueryForString2381)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteStatement.staticClass = @__class; 
			global::android.database.sqlite.SQLiteStatement._execute2378 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "execute", "()V"); 
			global::android.database.sqlite.SQLiteStatement._executeInsert2379 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "executeInsert", "()J"); 
			global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2380 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForLong", "()J"); 
			global::android.database.sqlite.SQLiteStatement._simpleQueryForString2381 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForString", "()Ljava/lang/String;"); 
		} 
	} 
} 
