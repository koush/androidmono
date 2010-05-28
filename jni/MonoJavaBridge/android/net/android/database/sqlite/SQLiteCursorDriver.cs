namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SQLiteCursorDriver 
	{ 
		global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1); 
		void cursorDeactivated(); 
		void cursorRequeried(android.database.Cursor arg0); 
		void cursorClosed(); 
		void setBindArguments(java.lang.String[] arg0); 
	} 

	public partial class SQLiteCursorDriver_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SQLiteCursorDriver.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SQLiteCursorDriver : java.lang.Object, SQLiteCursorDriver
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SQLiteCursorDriver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.__SQLiteCursorDriver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.__SQLiteCursorDriver(@__env); 
			} 
		} 
		internal __SQLiteCursorDriver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query2456; 
		 global::android.database.Cursor android.database.sqlite.SQLiteCursorDriver.query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.__SQLiteCursorDriver)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.__SQLiteCursorDriver._query2456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.__SQLiteCursorDriver.staticClass, global::android.database.sqlite.__SQLiteCursorDriver._query2456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorDeactivated2457; 
		 void android.database.sqlite.SQLiteCursorDriver.cursorDeactivated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.__SQLiteCursorDriver)) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver._cursorDeactivated2457); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver.staticClass, global::android.database.sqlite.__SQLiteCursorDriver._cursorDeactivated2457); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorRequeried2458; 
		 void android.database.sqlite.SQLiteCursorDriver.cursorRequeried(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.__SQLiteCursorDriver)) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver._cursorRequeried2458, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver.staticClass, global::android.database.sqlite.__SQLiteCursorDriver._cursorRequeried2458, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cursorClosed2459; 
		 void android.database.sqlite.SQLiteCursorDriver.cursorClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.__SQLiteCursorDriver)) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver._cursorClosed2459); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver.staticClass, global::android.database.sqlite.__SQLiteCursorDriver._cursorClosed2459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBindArguments2460; 
		 void android.database.sqlite.SQLiteCursorDriver.setBindArguments(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.__SQLiteCursorDriver)) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver._setBindArguments2460, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteCursorDriver.staticClass, global::android.database.sqlite.__SQLiteCursorDriver._setBindArguments2460, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.__SQLiteCursorDriver.staticClass = @__class; 
			global::android.database.sqlite.__SQLiteCursorDriver._query2456 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteCursorDriver.staticClass, "android.database.sqlite.SQLiteCursorDriver.query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.database.sqlite.__SQLiteCursorDriver._cursorDeactivated2457 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteCursorDriver.staticClass, "android.database.sqlite.SQLiteCursorDriver.cursorDeactivated", "()V"); 
			global::android.database.sqlite.__SQLiteCursorDriver._cursorRequeried2458 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteCursorDriver.staticClass, "android.database.sqlite.SQLiteCursorDriver.cursorRequeried", "(Landroid/database/Cursor;)V"); 
			global::android.database.sqlite.__SQLiteCursorDriver._cursorClosed2459 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteCursorDriver.staticClass, "android.database.sqlite.SQLiteCursorDriver.cursorClosed", "()V"); 
			global::android.database.sqlite.__SQLiteCursorDriver._setBindArguments2460 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteCursorDriver.staticClass, "android.database.sqlite.SQLiteCursorDriver.setBindArguments", "([Ljava/lang/String;)V"); 
		} 
	} 
} 
