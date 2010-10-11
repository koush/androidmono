namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteCursorDriver_))]
	public interface SQLiteCursorDriver  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _query2812;
		 global::android.database.Cursor android.database.sqlite.SQLiteCursorDriver.query(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._query2812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._query2812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _cursorDeactivated2813;
		 void android.database.sqlite.SQLiteCursorDriver.cursorDeactivated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated2813);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated2813);
		}
		internal static global::MonoJavaBridge.MethodId _cursorRequeried2814;
		 void android.database.sqlite.SQLiteCursorDriver.cursorRequeried(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried2814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried2814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cursorClosed2815;
		 void android.database.sqlite.SQLiteCursorDriver.cursorClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed2815);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed2815);
		}
		internal static global::MonoJavaBridge.MethodId _setBindArguments2816;
		 void android.database.sqlite.SQLiteCursorDriver.setBindArguments(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments2816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteCursorDriver_.staticClass, global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments2816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursorDriver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursorDriver"));
			global::android.database.sqlite.SQLiteCursorDriver_._query2812 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteCursorDriver_._cursorDeactivated2813 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorDeactivated", "()V");
			global::android.database.sqlite.SQLiteCursorDriver_._cursorRequeried2814 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorRequeried", "(Landroid/database/Cursor;)V");
			global::android.database.sqlite.SQLiteCursorDriver_._cursorClosed2815 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "cursorClosed", "()V");
			global::android.database.sqlite.SQLiteCursorDriver_._setBindArguments2816 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursorDriver_.staticClass, "setBindArguments", "([Ljava/lang/String;)V");
		}
	}
}
