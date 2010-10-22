namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteCursorDriver_))]
	public partial interface SQLiteCursorDriver  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1);
		void cursorDeactivated();
		void cursorRequeried(android.database.Cursor arg0);
		void cursorClosed();
		void setBindArguments(java.lang.String[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteCursorDriver))]
	public sealed partial class SQLiteCursorDriver_ : java.lang.Object, SQLiteCursorDriver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteCursorDriver_()
		{
			InitJNI();
		}
		internal SQLiteCursorDriver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _query4711;
		 global::android.database.Cursor android.database.sqlite.SQLiteCursorDriver.query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._query4711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._query4711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _cursorDeactivated4712;
		 void android.database.sqlite.SQLiteCursorDriver.cursorDeactivated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated4712);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated4712);
		}
		internal static global::MonoJavaBridge.MethodId _cursorRequeried4713;
		 void android.database.sqlite.SQLiteCursorDriver.cursorRequeried(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried4713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried4713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cursorClosed4714;
		 void android.database.sqlite.SQLiteCursorDriver.cursorClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed4714);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed4714);
		}
		internal static global::MonoJavaBridge.MethodId _setBindArguments4715;
		 void android.database.sqlite.SQLiteCursorDriver.setBindArguments(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments4715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments4715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursorDriver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursorDriver"));
			global::android.database.sqlite.SQLiteCursorDriver_._query4711 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated4712 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorDeactivated", "()V");
			global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried4713 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorRequeried", "(Landroid/database/Cursor;)V");
			global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed4714 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorClosed", "()V");
			global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments4715 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "setBindArguments", "([Ljava/lang/String;)V");
		}
	}
}
